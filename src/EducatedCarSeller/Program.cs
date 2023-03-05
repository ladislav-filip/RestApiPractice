using System.Reflection;
using EducatedCarSeller.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
    opt.SwaggerDoc("v1", new ()
    {
        Title = "Cars Seller", 
        Description = "API pro ukázku dokumentace pomocí Swagger/OpanApi pro Fullcom školení", 
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "L. Filip", Email = "ladislav.filip@fullsys.cz", Url = new Uri("https://www.fullsys.cz")
        },
        License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://www.mit.edu/~amini/LICENSE.md")}
    });
    opt.ExampleFilters();
});
builder.Services.AddSwaggerExamplesFromAssemblyOf<CarsSeller>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();