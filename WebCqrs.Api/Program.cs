using WebCqrs.Api.Extensions;
using WebCqrs.Application.UserProfiles.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices(typeof(Program));

var app = builder.Build();

app.RegisterPipelineComponents(typeof(Program));

app.Run();
