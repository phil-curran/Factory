using Factory.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder
    //         .Entity<EngineerMachine>(
    //             eb =>
    //             {
    //                 eb.HasNoKey();
    //                 eb.Property(v => v.EngineerName).HasColumnName("EngineerName");
    //             });
    // }
    
}