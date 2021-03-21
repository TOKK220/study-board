using Microsoft.Extensions.Configuration;
using StudyBoard.Core.Web.Setting;

namespace StudyBoard.DataFacade.WebApi {
	public class DataFacadeSettings : BaseAppSettings {
		public string DataBaseConnectionString => GetConnectionString("AuthDatabase");
		public DataFacadeSettings(IConfiguration configuration) : base(configuration) { }
	}
}