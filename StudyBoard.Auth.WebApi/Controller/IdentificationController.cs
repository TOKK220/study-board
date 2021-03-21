using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Core.Web.Controller;

namespace StudyBoard.Auth.WebApi.Controller
{
    /// <summary>
    /// Controller for determining User identifier
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class IdentificationController : BaseController
    {
        public IdentificationController(ILogger logger) : base(logger)
        {
        }
    }
}
