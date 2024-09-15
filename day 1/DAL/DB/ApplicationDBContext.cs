using day_1.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace day_1.DAL.DB
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MOHAMMEDALBASUO;Database=Day1Test;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

        }

        public DbSet<Employee> Employees { get; set; }
    }
    
}

