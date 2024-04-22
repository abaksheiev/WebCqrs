using WebCqrs.Api.Registrar;
using WebCqrs.Application.UserProfiles.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Hosting;

namespace WebCqrs.Api.Registras
{
    public class BogardRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfiles));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        }
    }
}
