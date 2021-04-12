using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudyBoard.Core.Web.Setting;
using System;
using System.Text;

namespace StudyBoard.Auth.WebApi
{
    public class AuthSettings : BaseAppSettings {
		public string DataBaseConnectionString => GetConnectionString("AuthDatabase");
		public string TokenIssuer => GetSettingValue<string>("Auth:Issuer");
		public string TokenAudience => GetSettingValue<string>("Auth:Audience");
        public int TokenLifetime => GetSettingValue<int>("Auth:TokenLifetime"); //seconds
        public string Secret => GetSettingValue<string>("Auth:Secret");
        public SymmetricSecurityKey SecurityKey => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
        public AuthSettings(IConfiguration configuration): base(configuration) {}
	}
}