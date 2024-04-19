using WebCqrs.Api.Controllers.Registrar;

namespace WebCqrs.Api.Controllers.Registras
{
    public class MvcWebAppRegistrar : IWebApplicationRegistrar
    {
        public void RegisterPipelineComponents(WebApplication app)
        {

            //app.UseHttpsRedirection();

            app.UseApiVersioning();
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
