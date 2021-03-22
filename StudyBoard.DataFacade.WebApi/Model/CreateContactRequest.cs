using Microsoft.AspNetCore.Mvc;

namespace StudyBoard.DataFacade.WebApi.Model
{
	public class CreateContactRequest
	{
		[BindProperty(Name = "firstName")]
		public string FirstName { get; set; }
		[BindProperty(Name = "lastName")]
		public string LastName { get; set; }
		[BindProperty(Name = "phoneNumber")]
		public string PhoneNumber { get; set; }
		[BindProperty(Name = "email")]
		public string Email { get; set; }
	}
}