using Lect3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lect3.Data
{
	public class EFCoreDemoContext : DbContext
	{
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Data Source=.\\sqlexpress;Initial Catalog=EFCoreDemo;Integrated Security=True;TrustServerCertificate=True;"
				);
		}
	}
}
