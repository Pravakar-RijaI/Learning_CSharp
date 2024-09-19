using entities.Models;
using Microsoft.EntityFrameworkCore;

namespace entities.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
