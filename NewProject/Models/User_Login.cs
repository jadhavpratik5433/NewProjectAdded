using System.ComponentModel.DataAnnotations;

namespace NewProject.Models
{
    public class User_Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null;
        [Required]
        public string Gender { get; set; } = null;
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; } = null;
        [DataType(DataType.Password)]
        public string Password { get; set; } = null;


    }
}
