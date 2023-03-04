using System.Reflection;
using CarSeller.Examples;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
    opt.SwaggerDoc("v1", new () { Title = "Cars Seller", Description = "API fo workshop by Fullcom", Version = "v1" });
    opt.ExampleFilters();
});
builder.Services.AddSwaggerExamplesFromAssemblyOf<CarItemExample>(); // plná cesta je zde úmyslně  - pro exaktní specifikace kde se examples mají hledat

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
