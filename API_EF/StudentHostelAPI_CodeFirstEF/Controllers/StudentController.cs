using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentHostelAPI_CodeFirstEF.Data;
using StudentHostelAPI_CodeFirstEF.DTOs;
using StudentHostelAPI_CodeFirstEF.Models;

namespace StudentHostelAPI_CodeFirstEF.Controllers
{
    [Authorize]

    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent(CreateStudentDTO dto)
        {
            var student = new Student
            {
                StudentName = dto.StudentName,
                Age = dto.Age,
                Gender = dto.Gender,
                Course = dto.Course
            };

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            var hostel = new Hostel
            {
                RoomNumber = dto.RoomNumber,
                StudentId = student.StudentId
            };

            _context.Hostels.Add(hostel);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
