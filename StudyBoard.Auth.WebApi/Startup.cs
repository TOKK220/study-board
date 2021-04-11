using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using StudyBoard.Auth.Repository;

namespace StudyBoard.Auth.WebApi
{
    public class Startup {
		private readonly AuthSettings _settings;
		public Startup(IConfiguration configuration) {
			_settings = new AuthSettings(configuration);
		}

		public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication("OAuth")
                .AddJwtBearer("OAuth", options =>
                {
					options.TokenValidationParameters = new TokenValidationParameters
                    {
						ValidIssuer = _settings.TokenIssuer,
						ValidAudience = _settings.TokenAudience,
						IssuerSigningKey = AuthConstants.SecurityKey
					};
                });
			services.AddSingleton(_settings);
            services.AddDbContext<AuthContext>(options =>
                options.UseNpgsql(_settings.DataBaseConnectionString));
			services.AddTransient<IAuthRepository, AuthRepository>();
        }

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}
			app.UseRouting();
            app.UseAuthentication();
            //app.UseAuthorization();
			app.UseEndpoints(endpoints => {
				endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
			});
		}
	}
}