using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Core.Model.Enum;
using StudyBoard.Core.Web.Controller;
using StudyBoard.DataFacade.WebApi.Model;

namespace StudyBoard.DataFacade.WebApi.Controller
{
	[ApiController]
	[Route("api/contact")]
	public class ContactController : BaseController
	{
		public ContactController(ILogger<ContactController> logger) : base(logger) { }
		[HttpPost("create")]
		[Authorize(Roles = nameof(UserRole.Admin))]
		public CreateContactResponse CreateContact(CreateContactRequest request) {
			return new CreateContactResponse();
		}
	}
}
