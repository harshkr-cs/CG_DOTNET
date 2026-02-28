using System.ComponentModel.DataAnnotations;

namespace StudentRegistrationSystemWithMVC_ADONET.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string StudentCode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        public string MotherName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid Mobile")]
        public string Mobile { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public byte[] Photo { get; set; }
    }
}
