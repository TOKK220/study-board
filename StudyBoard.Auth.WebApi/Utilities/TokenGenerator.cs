using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace StudyBoard.Auth.WebApi.Utilities
{
    public class TokenGenerator
    {
        private readonly AuthSettings _authSettings;

        public TokenGenerator(AuthSettings authSettings)
        {
            _authSettings = authSettings;
        }

        public string GenerateToken(Guid userId)
        {
            var signingCredentials = new SigningCredentials(_authSettings.SecurityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString())
            };
            var token = new JwtSecurityToken(_authSettings.TokenIssuer,
                _authSettings.TokenAudience,
                claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMilliseconds(_authSettings.TokenLifetime),
                signingCredentials: signingCredentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
