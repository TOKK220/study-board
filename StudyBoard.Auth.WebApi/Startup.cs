using System.Security.Permissions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudyBoard.Auth.Repository;

namespace StudyBoard.Auth.WebApi {
	public class Startup {
		private readonly AuthSettings _settings;
		public Startup(IConfiguration configuration) {
			_settings = new AuthSettings(configuration);
		}
		public void ConfigureServices(IServiceCollection services) {
			services.AddSingleton(_settings);
			services.AddDbContext<AuthContext>(options =>
				options.UseNpgsql(_settings.DataBaseConnectionString));
            services.AddSingleton<IAuthRepository, AuthRepository>();
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}
			app.UseRouting();
			app.UseEndpoints(endpoints => {
				endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
			});
		}
	}
}