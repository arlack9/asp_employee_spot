using core2.Models;
using Microsoft.EntityFrameworkCore;

namespace core2.Repository.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }


    //seeding
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Seed initial data for the DiaryEntry table
        modelBuilder.Entity<Employee>().HasData(
         new Employee()
          {
              Id = 1,
              Name = "Arjun",
              Age = 18,
              Dept = "CS"
          },

        new Employee()
        {
            Id = 2,
            Name = "Arun",
            Age = 20,
            Dept = "DA"
        },

        new Employee()
        {
            Id = 3,
            Name = "Akash",
            Age = 25,
            Dept = "Bio"
        }



            );

    }
}
