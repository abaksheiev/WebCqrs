using WebCqrs.Api.Controllers.Registras;

namespace WebCqrs.Api.Registrar
{
    public interface IWebApplicationRegistrar : IRegistrar
    {
        void RegisterPipelineComponents(WebApplication app);
    }
}
