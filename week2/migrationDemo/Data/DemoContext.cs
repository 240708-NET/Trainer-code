using Microsoft.EntityFrameworkCore;
using migrationDemo.Models;

public class DemoContext : DbContext{


    // Allows exteran code to be passed in the configurations 
    public DemoContext(DbContextOptions<DemoContext> options) : base(options)
    {
    }

    public DbSet<Departments> departments { get; set; }
    public DbSet<Employees> employees { get; set; }


}