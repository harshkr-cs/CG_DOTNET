using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using EmployeeManagementSystemMVC_ADONET.Models;


namespace EmployeeManagementSystemMVC_ADONET.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));
        }

        // READ
        public IActionResult Index()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Employee
                    {
                        EmpId = Convert.ToInt32(dr["EmpId"]),
                        Name = dr["Name"].ToString(),
                        AadharCard = dr["AadharCard"].ToString(),
                        Address = dr["Address"].ToString(),
                        DOB = Convert.ToDateTime(dr["DOB"]),
                        Salary = Convert.ToDecimal(dr["Salary"])
                    });
                }
            }

            return View(list);
        }

        // CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = GetConnection())
                {
                    string query = @"INSERT INTO Employees 
                                    (Name,AadharCard,Address,DOB,Salary)
                                    VALUES (@Name,@AadharCard,@Address,@DOB,@Salary)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@AadharCard", emp.AadharCard);
                    cmd.Parameters.AddWithValue("@Address", emp.Address);
                    cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // EDIT
        public IActionResult Edit(int id)
        {
            Employee emp = new Employee();

            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Employees WHERE EmpId=@EmpId", con);
                cmd.Parameters.AddWithValue("@EmpId", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                    emp.Name = dr["Name"].ToString();
                    emp.AadharCard = dr["AadharCard"].ToString();
                    emp.Address = dr["Address"].ToString();
                    emp.DOB = Convert.ToDateTime(dr["DOB"]);
                    emp.Salary = Convert.ToDecimal(dr["Salary"]);
                }
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = GetConnection())
                {
                    string query = @"UPDATE Employees SET 
                                    Name=@Name,
                                    AadharCard=@AadharCard,
                                    Address=@Address,
                                    DOB=@DOB,
                                    Salary=@Salary
                                    WHERE EmpId=@EmpId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@AadharCard", emp.AadharCard);
                    cmd.Parameters.AddWithValue("@Address", emp.Address);
                    cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            Employee emp = new Employee();

            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Employees WHERE EmpId=@EmpId", con);
                cmd.Parameters.AddWithValue("@EmpId", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                    emp.Name = dr["Name"].ToString();
                }
            }

            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Employees WHERE EmpId=@EmpId", con);
                cmd.Parameters.AddWithValue("@EmpId", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}
