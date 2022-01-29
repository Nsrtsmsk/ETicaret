using DataAccess.Concrete.EntityFramework.EFMapping;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-49SK5BV\SQLEXPRESS;Database=ETicaret;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new AdministratorsMap());
        }
        DbSet<Products> Products { get; set; }
        DbSet<Administrators> Administators { get; set; }
        DbSet<Categories> Categories { get; set; }
        DbSet<Users> Users { get; set; }
    }
}
