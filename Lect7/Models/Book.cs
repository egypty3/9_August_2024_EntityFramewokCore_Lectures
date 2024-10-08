using System.ComponentModel.DataAnnotations.Schema;

namespace Lect7.Models
{
	
	public class Book
	{
		
		public int BookId { get; set; }
		
		public string Title { get; set; }
		
		public int AuthorId { get; set; }

		// Navigation Properties
		
		public Author Author { get; set; }

        public AuditLog AuditLog { get; set; }
    }
}
