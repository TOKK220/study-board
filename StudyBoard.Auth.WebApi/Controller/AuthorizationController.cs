using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Core.Web.Controller;

namespace StudyBoard.Auth.WebApi.Controller {
	[Route("authorization")]
	public class AuthorizationController : BaseController {
		public AuthorizationController(ILogger logger) : base(logger) { }
	}
}