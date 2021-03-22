using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudyBoard.DataFacade.Data;

namespace StudyBoard.DataFacade.WebApi {
	public class Startup {
		private readonly DataFacadeSettings _settings;
		public Startup(IConfiguration configuration) {
			_settings = new DataFacadeSettings(configuration);
		}
		public void ConfigureServices(IServiceCollection services) {
			services.AddSingleton(_settings);
			services.AddDbContext<DataFacadeDbContext>(options =>
				options.UseNpgsql(_settings.DataBaseConnectionString));
			services.AddControllers();
			services.AddDatabaseDeveloperPageExceptionFilter();
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}
			app.UseRouting();
			app.UseEndpoints(builder => builder.MapControllers());
		}
	}
}