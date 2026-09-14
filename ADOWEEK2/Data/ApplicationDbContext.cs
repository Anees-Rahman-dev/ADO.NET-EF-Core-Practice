using ADOWEEK2.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace ADOWEEK2.Data
{
    public class ApplicationDbContext : DbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Student>()
        //        .HasOne(e => e.Department)
        //        .WithMany(d => d.Students)
        //        .HasForeignKey(e => e.DepartmentId);
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            

        }
        public DbSet<Student> Students { get; set; } 
        public DbSet<Department> Departments { get; set; }


    }
}
