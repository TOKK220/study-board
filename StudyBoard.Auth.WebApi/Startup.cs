using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StudyBoard.Auth.WebApi {
	public class Startup {
		private readonly AuthSettings _settings;
		public Startup(IConfiguration configuration) {
			_settings = new AuthSettings(configuration);
		}
		public void ConfigureServices(IServiceCollection services) {
			services.AddSingleton(_settings);
			var conn = _settings.DataBaseConnectionString;
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