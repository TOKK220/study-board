using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Auth.Model;
using StudyBoard.Auth.WebApi.Model;
using StudyBoard.Core.Model.Enum;
using StudyBoard.Core.Web.Controller;

namespace StudyBoard.Auth.WebApi.Controller {
	/// <summary>
	/// Controller for checking user login and password
	/// </summary>
	[Route("authentication")]
	public class AuthenticationController : BaseController {
        private readonly IAuthenticationBLL _authenticationBLL;
        public AuthenticationController(ILogger logger, IAuthenticationBLL authenticationBLL) : base(logger)
        {
            _authenticationBLL = authenticationBLL;
        }

        public RegistrationResponse Register(RegistrationRequest registrationRequest)
        {
            // TODO: validate registrationRequest
            var user = new User
            {
                Id = new Guid(),
                Login = registrationRequest.Login,
                Password = registrationRequest.Password,
                Roles = registrationRequest.Roles.Select(role => (UserRole)role).ToList()
            };
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                Email = registrationRequest.Email,
                FirstName = registrationRequest.FirstName,
                LastName = registrationRequest.LastName,
                PhoneNumber = registrationRequest.PhoneNumber
            };
            _authenticationBLL.Register(user, contact);
            return new RegistrationResponse();
        }
	}
}