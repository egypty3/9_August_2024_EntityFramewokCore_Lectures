using Lect6.Models;
using Microsoft.EntityFrameworkCore;

namespace Lect6.Data
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
