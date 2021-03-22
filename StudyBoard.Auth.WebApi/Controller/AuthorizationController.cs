using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Core.Web.Controller;

namespace StudyBoard.Auth.WebApi.Controller
{
	/// <summary>
	/// Controller for granting a certain person the rights to perform certain actions.
	/// </summary>
	[Route("authorization")]
	public class AuthorizationController : BaseController
	{
		public AuthorizationController(ILogger logger) : base(logger) { }
	}
}