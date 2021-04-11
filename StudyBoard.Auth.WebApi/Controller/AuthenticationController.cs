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

namespace StudyBoard.Auth.WebApi.Controller
{
    /// <summary>
    /// Controller for checking user login and password
    /// </summary>
    [Route("authentication")]
	public class AuthenticationController : BaseController {
        private readonly IAuthenticationBLL _authenticationBLL;
        private readonly AuthSettings _authSettings;

        public AuthenticationController(ILogger logger, IAuthenticationBLL authenticationBLL,
            AuthSettings authSettings) : base(logger)
        {
            _authenticationBLL = authenticationBLL;
            _authSettings = authSettings;
        }

        public IActionResult Authenticate(Guid userId, string email)
        {
            var signingCredentials = new SigningCredentials(AuthConstants.SecurityKey, SecurityAlgorithms.HmacSha256);
            var claims = new []
            {
                new Claim(JwtRegisteredClaimNames.Email, email), 
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString())
            };
            var token = new JwtSecurityToken(_authSettings.TokenIssuer, 
                _authSettings.TokenAudience, 
                claims, 
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMilliseconds(_authSettings.TokenLifetime),
                signingCredentials: signingCredentials);
            return Ok(new { access_token = new JwtSecurityTokenHandler().WriteToken(token) });
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