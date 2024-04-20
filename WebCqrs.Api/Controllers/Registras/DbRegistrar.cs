using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebCqrs.Api.Controllers.Registrar;
using WebCqrs.Dal;

namespace WebCqrs.Api.Controllers.Registras
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");
           

            builder.Services.AddDbContext<DataContext>(options =>  options.UseSqlServer(cs));

        }
    }
}
