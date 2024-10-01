using System.ComponentModel.DataAnnotations;

namespace Lect5.Models
{
	public class AuthorsBooks
	{ 
		public int AuthorId { get; set; }
      
        public int BookId { get; set; }

        // Navigation Properties
        public  Author Author { get; set; }
        public Book Book { get; set; }
    }
}
