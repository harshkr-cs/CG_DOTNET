using Microsoft.EntityFrameworkCore;
using StudentHostelAPI_CodeFirstEF.Models;

namespace StudentHostelAPI_CodeFirstEF.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Hostel> Hostels { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Hostel)
                .WithOne(h => h.Student)
                .HasForeignKey<Hostel>(h => h.StudentId);
        }
    }
}
