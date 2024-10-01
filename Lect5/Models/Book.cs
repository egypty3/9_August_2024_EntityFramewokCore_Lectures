using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lect5.Models
{
	public class Book
	{
		//[Key]
        public int BookId { get; set; }
		public string Title { get; set; }




		// Navigation Properties
		[NotMapped]
		public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
