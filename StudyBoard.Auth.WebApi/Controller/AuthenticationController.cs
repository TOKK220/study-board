using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Core.Web.Controller;

namespace StudyBoard.Auth.WebApi.Controller {
	[Route("authentication")]
	public class AuthenticationBaseController : BaseController {
		public AuthenticationBaseController(ILogger logger) : base(logger) { }
	}
}