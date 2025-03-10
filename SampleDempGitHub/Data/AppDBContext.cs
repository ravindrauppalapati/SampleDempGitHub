using Microsoft.EntityFrameworkCore;
using SampleDempGitHub.Models;

namespace SampleDempGitHub.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opts):base(opts)
        {
            
        }

        public DbSet<Employee> employees { get; set; }
    }
}
