using Microsoft.AspNetCore.Builder;

namespace AOM.CQRS.Api.Configuration._2.Configure
{
    public static class SwaggerConfigure
    {
        public static void SwaggerConfigureApp(this IApplicationBuilder app) 
        {   
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "CQRS.Api v1");
                c.DefaultModelExpandDepth(0);
                c.DefaultModelsExpandDepth(-1);
            });
        }
    }
}
