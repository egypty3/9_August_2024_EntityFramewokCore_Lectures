
using Lect8.Models;
using Microsoft.EntityFrameworkCore;

namespace Lect8.Data
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
        public DbSet<Contact> Contacts { get; set; }

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


			// Contact Configuration
			modelBuilder.Entity<Contact>()
				.Property(c => c.IsActive)
				.HasDefaultValue(true);

			modelBuilder.Entity<Contact>()
				.Property(c => c.DateCreated)
				.HasDefaultValueSql("getdate()");

			modelBuilder.Entity<Contact>()
				.Property(c => c.FirstName)
				.HasMaxLength(30);

			modelBuilder.Entity<Contact>()
				.Property(c => c.LastName)
				.HasMaxLength(30);
		}

	}
}
