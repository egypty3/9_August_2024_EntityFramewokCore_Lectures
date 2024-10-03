using System.ComponentModel.DataAnnotations.Schema;

namespace Lect6.Models
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }

		// Navigation Properties
		[InverseProperty("CreatedBy")]
        public List<Contact> ContactsCreated { get; set; }
		[InverseProperty("UpdatedBy")]		
		public List<Contact> ContactsUpdated { get; set; }
	}
}
