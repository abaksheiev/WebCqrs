using Microsoft.EntityFrameworkCore;
using WebCqrs.Api.Registrar;
using WebCqrs.Dal;

namespace WebCqrs.Api.Registras
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
