using Microsoft.Extensions.Configuration;

namespace StudyBoard.Auth.WebApi {
	public class AuthSettings {
		private IConfiguration Configuration { get; }
		public string DataBaseConnectionString => GetConnectionString("AuthDatabase");
		public AuthSettings(IConfiguration configuration) {
			Configuration = configuration;
		}
		protected virtual string GetConnectionString(string name) {
			return Configuration.GetConnectionString(name);
		}
		protected virtual T GetSettingValue<T>(string name) {
			return Configuration.GetValue<T>(name);
		}
	}
}