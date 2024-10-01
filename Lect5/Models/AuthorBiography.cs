namespace Lect5.Models
{
	public class AuthorBiography
	{
        public int AuthorBiographyId { get; set; }
        public String Bigraphy { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PlaceOfBirth { get; set; }

        public int AuthorId { get; set; }

        // Navigation Properties
        public Author Author { get; set; }
    }
}
