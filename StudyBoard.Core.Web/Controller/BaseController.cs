using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudyBoard.Core.Web.Controller
{
	[ApiController]
	public abstract class BaseController: ControllerBase
	{
		protected ILogger Logger { get; }
		protected BaseController(ILogger logger) {
			Logger = logger;
		}
		[HttpGet("ping")]
		public virtual string Ping() {
			return "pong";
		}
	}
}