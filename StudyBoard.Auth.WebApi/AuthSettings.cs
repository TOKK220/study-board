using Microsoft.Extensions.Configuration;
using StudyBoard.Core.Web.Setting;

namespace StudyBoard.Auth.WebApi {
	public class AuthSettings : BaseAppSettings {
		public string DataBaseConnectionString => GetConnectionString("AuthDatabase");
		public AuthSettings(IConfiguration configuration): base(configuration) {}
	}
}