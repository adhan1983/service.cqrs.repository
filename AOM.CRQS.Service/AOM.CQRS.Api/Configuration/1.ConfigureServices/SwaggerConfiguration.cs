using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace AOM.CQRS.Api.Configuration._1.ConfigureServices
{
    public static class SwaggerConfiguration
    {
        public static void SwaggerConfigurationServices(this IServiceCollection services) 
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = $"CQRS Service " + $"{ Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}",
                    Version = "v1"
                });
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                c.DocumentFilterDescriptors.AsReadOnly();
                c.CustomSchemaIds(i => i.FullName);
            });
        }
    }
}
