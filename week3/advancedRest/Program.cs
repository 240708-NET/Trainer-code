using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory; 
using advancedRest.Models;

var builder = WebApplication.CreateBuilder(args);



var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddDbContext<DemoDbContext>(options => 
    options.UseSqlServer(connectionString)); // use user secrets for db connection string


builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IMemoryCache, MemoryCache>(); // configure memory cache service

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(); // add CORS config

var app = builder.Build();

if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}


//Cors demo

app.MapControllers();

app.UseCors(options => 
    options.AllowAnyHeader()
    //.AllowAnyOrigin() -- allow any origin
    .WithOrigin("http://localhost:3000")
    .AllowAnyMethod()
    .AllowCredentials()
)
app.Run();
