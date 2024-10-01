using System.ComponentModel.DataAnnotations.Schema;

namespace Lect5.Models
{
	public class Author
	{
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


		// Navigation Properties
		[NotMapped]
		public ICollection<Book> Books { get; set; } = new List<Book>();
        public AuthorBiography Biography { get; set; }
    }
}
