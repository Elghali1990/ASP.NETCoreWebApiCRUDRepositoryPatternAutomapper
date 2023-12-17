using System.ComponentModel.Design;
using FormulaOne.Entities.DbSet;
using Microsoft.EntityFrameworkCore;

namespace FormuaOne.DataService.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>Options):base(Options){

    }
    
    public virtual DbSet<Driver> Drivers {get;set;}
    public virtual DbSet<Archievement> Archievements {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Archievement>(e=>e.HasOne<Driver>()
                                                               .WithMany(x=>x.Archievements)
                                                               .HasForeignKey(d=>d.DriverId)
                                                               .OnDelete(DeleteBehavior.NoAction)
                                                               .HasConstraintName("FK_Archivement_driver"));
        base.OnModelCreating(modelBuilder);
    }
}
