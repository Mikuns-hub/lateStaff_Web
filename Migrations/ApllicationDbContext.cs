using Microsoft.EntityFrameworkCore;
using ololade_web.Models;

namespace ololade_web.Data
{
	public class ApllicationDbContext :DbContext
	{
        public ApllicationDbContext(DbContextOptions<ApllicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Employee> Employees { get; set; } 
    }
}
