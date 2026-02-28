using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_ADO_NET.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Marks { get; set; }

        [Required]
        public string Department { get; set; }

    }
}
