using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Core.Web.Controller;

namespace StudyBoard.Auth.WebApi.Controller {
	/// <summary>
	/// Controller for checking user login and password
	/// </summary>
	[Route("authentication")]
	public class AuthenticationBaseController : BaseController {
		public AuthenticationBaseController(ILogger logger) : base(logger) { }
	}
}