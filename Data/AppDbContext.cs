using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		// Add this DbSet
		public DbSet<Users> Users { get; set; }
		// Add this DbSet
		public DbSet<Post> Post { get; set; }
		// Add this DbSet
		public DbSet<Commenti> Commenti { get; set; }
		// Add this DbSet
		public DbSet<Risposte> Risposte { get; set; }
	}
}
