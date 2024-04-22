using Microsoft.AspNetCore.Mvc.ApiExplorer;
using WebCqrs.Api.Registrar;

namespace WebCqrs.Api.Controllers.Registras
{
    public class MvcWebAppRegistrar : IWebApplicationRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options => {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.ApiVersion.ToString());
                }
            });

            app.UseApiVersioning();
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
