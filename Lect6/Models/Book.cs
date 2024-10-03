using System.ComponentModel.DataAnnotations.Schema;

namespace Lect6.Models
{
	[Table("Books",Schema ="Readables")]
	public class Book
	{
		
		public int BookId { get; set; }
		[Column("Description",TypeName ="nvarchar(100)")]
		public string Title { get; set; }
		//[ForeignKey("Author")]
		public int AuthorFK { get; set; }

		// Navigation Properties
		[ForeignKey("AuthorFK")]
		[NotMapped]
		public Author Author { get; set; }	
	}
}
