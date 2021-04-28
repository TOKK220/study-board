using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using StudyBoard.Auth.Repository;
using StudyBoard.Auth.WebApi.Utilities;

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
						IssuerSigningKey = _settings.SecurityKey
					};
                });
			services.AddSingleton(_settings);
            services.AddDbContext<AuthContext>(options => options.UseNpgsql(_settings.DataBaseConnectionString)); 
            services.AddTransient<IAuthenticationBLL, AuthenticationBLL>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddSingleton<TokenGenerator>();
            services.AddControllers();
			services.AddSwaggerGen(c => c.ResolveConflictingActions(apiDescription => apiDescription.First()));
        }

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Auth API");
                });
			}
            app.UseRouting();
            app.UseAuthentication();
            //app.UseAuthorization();
            app.UseEndpoints(builder => builder.MapControllers()
			    //builder.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
			);
		}
	}
}