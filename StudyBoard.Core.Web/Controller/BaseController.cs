using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudyBoard.Core.Web.Controller
{
	[ApiController]
	public abstract class Controller: ControllerBase {
		protected ILogger Logger { get; }
		protected Controller(ILogger logger) {
			Logger = logger;
		}
		[HttpGet("ping")]
		public virtual string Ping() {
			return "pong";
		}
	}
}