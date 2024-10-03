namespace Lect6.Models
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		// Navigation Properties
		public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }

    }
}
