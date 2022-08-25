using CarDescription_Backend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(setup =>
{
    setup.AddPolicy("ReactLocalPolicy",
          config =>
          {
              config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
          });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CarContext>(options =>
{
    options.UseInMemoryDatabase("Cars");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ReactLocalPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseRouting();



app.Run();
