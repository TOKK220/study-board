using Microsoft.Extensions.Configuration;
using StudyBoard.Core.Web.Setting;
using System;

namespace StudyBoard.Auth.WebApi
{
    public class AuthSettings : BaseAppSettings {
		public string DataBaseConnectionString => GetConnectionString("AuthDatabase");
		public string TokenIssuer => GetConnectionString("Auth.Issuer");
		public string TokenAudience => GetConnectionString("Auth.Audience");
        public int TokenLifetime => Int32.Parse(GetConnectionString("Auth.TokenLifetime")); //seconds
        public AuthSettings(IConfiguration configuration): base(configuration) {}
	}
}