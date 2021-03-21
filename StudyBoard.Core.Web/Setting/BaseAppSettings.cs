using Microsoft.Extensions.Configuration;

namespace StudyBoard.Core.Web.Setting
{
	public abstract class BaseAppSettings
	{
		protected IConfiguration Configuration { get; }
		protected BaseAppSettings(IConfiguration configuration) {
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
