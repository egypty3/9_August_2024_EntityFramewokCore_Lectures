using System.ComponentModel.DataAnnotations.Schema;

namespace Lect6.Models
{
	public class Author
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AuthorId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		[NotMapped]
		public string FullName => $"{FirstName} {LastName}";
        // Navigation Properties
        [NotMapped]
        public ICollection<Book> Books { get; set; }
    }
}
