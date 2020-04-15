using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using AOM.CQRS.Api.Configuration._2.Configure;
using Microsoft.Extensions.DependencyInjection;
using AOM.CQRS.Api.Configuration._1.ConfigureServices;
using AOM.CQRS.Api.Handlers;
using MediatR;
using System.Reflection;
using AOM.CQRS.Api.Repository.Interfaces;
using AOM.CQRS.Api.Repository;
using AOM.CQRS.Api.Services.Interfaces;
using AOM.CQRS.Api.Services;

namespace AOM.CQRS.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEmailService, EmailService>();

            services.SwaggerConfigurationServices();
            
            services.AddMediatR(Assembly.GetExecutingAssembly());

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())            
                app.UseDeveloperExceptionPage();
            
            app.SwaggerConfigureApp();
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
