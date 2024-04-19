using WebCqrs.Api.Controllers.Registras;

namespace WebCqrs.Api.Controllers.Registrar
{
    public interface IWebApplicationRegistrar : IRegistrar
    {
        void RegisterPipelineComponents(WebApplication app);
    }
}
