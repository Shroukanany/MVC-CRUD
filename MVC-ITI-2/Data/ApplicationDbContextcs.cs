using Microsoft.EntityFrameworkCore;
using MVC_ITI_2.Models;

namespace MVC_ITI_2.Data
{
    public class ApplicationDbContextcs : DbContext
    {
        public ApplicationDbContextcs() { }
        public ApplicationDbContextcs(DbContextOptions options) : base(options) { }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MNC-ITI-2;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
