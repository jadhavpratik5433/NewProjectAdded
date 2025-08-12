using Microsoft.EntityFrameworkCore;

namespace NewProject.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

       // public DbSet<Student> Students { get; set; }
        public DbSet<User_Login> User_Logins { get; set; }



    }
}
