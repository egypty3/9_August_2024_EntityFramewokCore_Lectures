using System.ComponentModel.DataAnnotations.Schema;

namespace Lect7.Models
{
	public class Author
	{
		public int AuthorId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
	
		public string FullName => $"{FirstName} {LastName}";
        // Navigation Properties
        
        public ICollection<Book> Books { get; set; }
		public AuditLog AuditLog { get; set; }
	}
}
