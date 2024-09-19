using ExamWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamWebApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<BAG> BAG;
	}
}
