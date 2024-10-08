
using Lect7.Models;
using Microsoft.EntityFrameworkCore;

namespace Lect7.Data
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }


		//public DbSet<Contact> Contacts { get; set; }
		//public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			// Model-Wide configuration
			modelBuilder.HasDefaultSchema("MyCustomSchema");
			modelBuilder.Ignore<AuditLog>();

			// Author Configuration 
			modelBuilder
				.Entity<Author>()
				.Property(a => a.FirstName)
				.IsRequired();

			//modelBuilder
			//	.Entity<Author>()
			//	.Property(a => a.FirstName)
			//	.HasAnnotation("Required", new object());

			modelBuilder
				.Entity<Author>()
				.Property(a => a.LastName)
				.IsRequired();

			// Book Configuration

		}

	}
}
