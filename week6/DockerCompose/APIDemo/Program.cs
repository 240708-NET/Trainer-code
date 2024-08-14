using System;

var builder = WebApplication.CreateBuilder(args);

string MyAllowAllOrigins = "_myAllowAllOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowAllOrigins,
    builder =>
    {
        builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
    });
});

var app = builder.Build();

//app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

int count = 0;

app.MapGet("/count", () =>
{
    count++;
    return count;
});

app.MapGet("/time", () =>
{
    return DateTime.Now;
});

app.MapGet("/", () =>
{
    string Hello = "Hello there! I'm alive!";
    return Hello;
});

app.UseCors(MyAllowAllOrigins);

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
