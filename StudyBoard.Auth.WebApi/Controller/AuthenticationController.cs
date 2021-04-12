using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using StudyBoard.Auth.Model;
using StudyBoard.Auth.WebApi.Model;
using StudyBoard.Core.Model.Enum;
using StudyBoard.Core.Web.Controller;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using StudyBoard.Auth.WebApi.Utilities;

namespace StudyBoard.Auth.WebApi.Controller
{
    /// <summary>
    /// Controller for checking user login and password
    /// </summary>
    [Route("authentication")]
	public class AuthenticationController : BaseController {
        private readonly IAuthenticationBLL _authenticationBLL;
        private readonly AuthSettings _authSettings;
        private readonly TokenGenerator _tokenGenerator;

        public AuthenticationController(ILogger logger, IAuthenticationBLL authenticationBLL,
            AuthSettings authSettings,
            TokenGenerator tokenGenerator) : base(logger)
        {
            _authenticationBLL = authenticationBLL;
            _authSettings = authSettings;
            _tokenGenerator = tokenGenerator;
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            var user = _authenticationBLL.Login(login, password);
            return Ok(new { accessToken = _tokenGenerator.GenerateToken(user.Id) });
        }

        [HttpPost]
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