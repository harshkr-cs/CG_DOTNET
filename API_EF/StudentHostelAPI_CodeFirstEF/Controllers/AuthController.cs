using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentHostelAPI_CodeFirstEF.Data;
using StudentHostelAPI_CodeFirstEF.DTOs;
using StudentHostelAPI_CodeFirstEF.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentHostelAPI_CodeFirstEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public AuthController(AppDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            var user = new User
            {
                Username = dto.Username,
                Password = dto.Password,
                Role = "User"
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("User Registered");
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO dto)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Username == dto.Username && x.Password == dto.Password);

            if (user == null)
                return Unauthorized();

            var claims = new[]
            {
                 new Claim(ClaimTypes.Name, user.Username),
                 new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}
