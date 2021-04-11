using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace StudyBoard.Auth.WebApi
{
    public static class AuthConstants
    {
        public const string Secret = "should_be_too_long_and_too_secret_so_anyone_can_ever_reach";
        public static SymmetricSecurityKey SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
    }
}
