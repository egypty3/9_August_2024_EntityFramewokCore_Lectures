using Lect5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lect5.Data
{
	public class BookStoreContext : DbContext
	{
		public BookStoreContext(DbContextOptions<BookStoreContext> options)
					: base(options)
		{

		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<AuthorsBooks> AuthorsBooks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AuthorsBooks>()
			   .HasKey(bc => new { bc.AuthorId, bc.BookId });			   
			 
		}
	}
}
