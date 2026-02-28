using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StudentRegistrationSystemWithMVC_ADONET.Models;
using System.Data;
using Rotativa.AspNetCore;

namespace StudentRegistrationSystemWithMVC_ADONET.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration _configuration;

        public StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnection()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

        // LIST
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection con = new SqlConnection(GetConnection()))
            {
                string query = "SELECT Id, StudentCode, Name FROM Students";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        StudentCode = reader["StudentCode"].ToString(),
                        Name = reader["Name"].ToString()
                    });
                }
            }

            return View(students);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student, IFormFile ImageFile)
        {
            if (ImageFile == null)
            {
                ModelState.AddModelError("", "Photo is required");
                return View(student);
            }

            if (ModelState.IsValid)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ImageFile.CopyTo(ms);
                    student.Photo = ms.ToArray();
                }

                using (SqlConnection con = new SqlConnection(GetConnection()))
                {
                    string query = @"INSERT INTO Students2
                    (StudentCode, Name, FatherName, MotherName, Address, Mobile, Email, Photo)
                    VALUES (@StudentCode,@Name,@FatherName,@MotherName,@Address,@Mobile,@Email,@Photo)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@StudentCode", student.StudentCode);
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@FatherName", student.FatherName);
                    cmd.Parameters.AddWithValue("@MotherName", student.MotherName);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = student.Photo;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }

            return View(student);
        }

        private Student GetStudentById(int id)
        {
            Student student = new Student();

            using (SqlConnection con = new SqlConnection(GetConnection()))
            {
                string query = "SELECT * FROM Students WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.StudentCode = reader["StudentCode"].ToString();
                    student.Name = reader["Name"].ToString();
                    student.FatherName = reader["FatherName"].ToString();
                    student.MotherName = reader["MotherName"].ToString();
                    student.Address = reader["Address"].ToString();
                    student.Mobile = reader["Mobile"].ToString();
                    student.Email = reader["Email"].ToString();
                    student.Photo = (byte[])reader["Photo"];
                }
            }

            return student;
        }

        public IActionResult DownloadIdCard(int id)
        {
            var student = GetStudentById(id);

            return new ViewAsPdf("IDCard", student)
            {
                FileName = "StudentIDCard.pdf"
            };
        }
    }
}
