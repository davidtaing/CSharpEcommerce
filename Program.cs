using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add the necessary NuGet packages
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo { Title = "eCommerce API", Description = "eCommerce API", Version = "v1" });
});

var app = builder.Build();

// Enable Swagger UI
app.UseSwagger();
app.UseSwaggerUI(c =>
{
  c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API v1");
});

app.MapGet("/", () => "Hello World!");

app.Run();
