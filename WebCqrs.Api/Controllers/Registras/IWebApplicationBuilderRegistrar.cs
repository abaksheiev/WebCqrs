using WebCqrs.Api.Controllers.Registras;

namespace WebCqrs.Api.Registrar
{
    public interface IWebApplicationBuilderRegistrar : IRegistrar
    {
        void RegisterServices(WebApplicationBuilder builder);
    }
}
