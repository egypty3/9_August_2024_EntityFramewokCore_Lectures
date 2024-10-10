using System.ComponentModel.DataAnnotations.Schema;

namespace Lect8.Models
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }

		// Navigation Properties		
        public List<Contact> ContactsCreated { get; set; }
		
		public List<Contact> ContactsUpdated { get; set; }
	}
}
