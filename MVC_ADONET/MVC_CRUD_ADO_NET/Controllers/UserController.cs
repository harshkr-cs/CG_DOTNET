using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_ADO_NET.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MVC_CRUD_ADO_NET.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnection()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

        // READ
        public IActionResult Index()
        {
            List<User> users = new List<User>();

            using (SqlConnection con = new SqlConnection(GetConnection()))
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Marks = (int)reader["Marks"],
                        Department = reader["Department"].ToString()
                    });
                }
            }

            return View(users);
        }

        // CREATE - GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE - POST
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(GetConnection()))
                {
                    string query = "INSERT INTO Users (Name, Marks, Department) VALUES (@Name, @Marks, @Department)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Marks", user.Marks);
                    cmd.Parameters.AddWithValue("@Department", user.Department);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // EDIT - GET
        public IActionResult Edit(int id)
        {
            User user = new User();

            using (SqlConnection con = new SqlConnection(GetConnection()))
            {
                string query = "SELECT * FROM Users WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.Marks = (int)reader["Marks"];
                    user.Department = reader["Department"].ToString();
                }
            }

            return View(user);
        }

        // EDIT - POST
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(GetConnection()))
                {
                    string query = "UPDATE Users SET Name=@Name, Marks=@Marks, Department=@Department WHERE Id=@Id";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Marks", user.Marks);
                    cmd.Parameters.AddWithValue("@Department", user.Department);
                    cmd.Parameters.AddWithValue("@Id", user.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(GetConnection()))
            {
                string query = "DELETE FROM Users WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }
    }
}