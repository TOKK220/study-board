using System.Collections.Generic;

namespace StudyBoard.Auth.WebApi.Model {
	public class RegistrationRequest {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public List<int> Roles { get; set; }
	}
}