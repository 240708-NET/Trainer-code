using Microsoft.EntityFrameworkCore;
using patientTracker.Data;
using patientTracker.Services;
using patientTracker.Data.Repositories;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<PatientTrackerContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddCors();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication("Bearer").AddJwtBearer();
//Add dependencyes
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IValidatinService, ValidateService>();
builder.Services.AddScoped<IHashingService, HashingService>();
builder.Services.AddScoped<JWTService>();


//Add swagger
var app = builder.Build();
app.MapControllers();
  if (app.Environment.IsDevelopment())
  {
    app.UseSwagger();
    app.UseSwaggerUI();
  }

//Handle CORS
app.UseCors(options=>options.AllowAnyHeader()
              .WithOrigins("http://localhost:3000")
              .AllowAnyMethod()
              .AllowCredentials()
              );

app.UseAuthorization();

app.Run();
