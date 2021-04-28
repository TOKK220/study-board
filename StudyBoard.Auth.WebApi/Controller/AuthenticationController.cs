using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudyBoard.Auth.Model;
using StudyBoard.Auth.WebApi.Model;
using StudyBoard.Auth.WebApi.Utilities;
using StudyBoard.Core.Model.Enum;
using StudyBoard.Core.Web.Controller;
using System;
using System.Linq;

namespace StudyBoard.Auth.WebApi.Controller
{
    /// <summary>
    /// Controller for checking user login and password
    /// </summary>
    [Route("authentication")]
	public class AuthenticationController : BaseController {
        private readonly IAuthenticationBLL _authenticationBLL;
        private readonly TokenGenerator _tokenGenerator;

        public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationBLL authenticationBLL,
            TokenGenerator tokenGenerator) : base(logger)
        {
            _authenticationBLL = authenticationBLL;
            _tokenGenerator = tokenGenerator;
        }

        [HttpPost("login")]
        public IActionResult Login(string login, string password)
        {
            var user = _authenticationBLL.Login(login, password);
            return Ok(new { accessToken = _tokenGenerator.GenerateToken(user.Id) });
        }

        [HttpPost("register")]
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

            var token = _tokenGenerator.GenerateToken(user.Id);
            return new RegistrationResponse
            {
                Token = token
            };
        }
	}
}