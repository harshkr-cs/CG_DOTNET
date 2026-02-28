
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystemMVC_ADONET.Models
{
    public class Employee
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Aadhar Card is required")]
        [RegularExpression(@"^[0-9]{12}$", ErrorMessage = "Aadhar must be 12 digits")]
        public string AadharCard { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        [Range(1, 10000000)]
        public decimal Salary { get; set; }
    }
}
