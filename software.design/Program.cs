using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TVShowContext>(options =>
    options
        .UseNpgsql("Host=localhost;Database=lab2db;Username=postgres;Password=Jamen2001")
        .UseSnakeCaseNamingConvention());

builder.Services.AddScoped<TVShowService>();

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
