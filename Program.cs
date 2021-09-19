using miniapi.Extensions;

var builder = WebApplication.CreateBuilder(args);
ServiceExtensions.Configure(builder.Services);
var app = builder.Build();

app.MapGraphQL();

app.Run();
