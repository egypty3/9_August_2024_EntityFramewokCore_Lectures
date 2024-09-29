using System.ComponentModel.DataAnnotations;

namespace Lect3.Models
{
	public class Book
	{
		//[Key]
        public int BookId { get; set; }
		public string Title { get; set; }
        public int AuthorId { get; set; }

        // Navigation Properties
        public Author Author { get; set; }
    }
}
