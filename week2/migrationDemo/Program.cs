using migrationDemo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddDbContext<DemoContext>(options => 
    options.UseSqlServer(connectionString)); // use user secrets for db connection string

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();
