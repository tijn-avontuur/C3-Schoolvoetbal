using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace C3_Schoolvoetbal_Backend;

public static class Program {
    public static void Main(string[] args) {
        var env = new Env("../../.env");

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<SchoolVoetbalDbContext>(options => options.UseMySql(
            $"server={env.Get("DB_HOST", "127.0.0.1")};port={env.Get("DB_PORT", "3306")};user={env.Get("DB_USERNAME", "root")};password={env.Get("DB_PASSWORD", "")};database={env.Get("DB_DATABASE")};",
            ServerVersion.Parse("8.0.21-mysql")
        ));
        builder.Services.AddAuthorization();
        builder.Services.AddIdentityApiEndpoints<IdentityUser>()
            .AddEntityFrameworkStores<SchoolVoetbalDbContext>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment()) {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapIdentityApi<IdentityUser>();

        var summaries = new[] {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        app.MapGet("/weatherforecast", (HttpContext httpContext) => {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                        new WeatherForecast {
                            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                            TemperatureC = Random.Shared.Next(-20, 55),
                            Summary = summaries[Random.Shared.Next(summaries.Length)]
                        })
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi()
            .RequireAuthorization();

        app.Run();
    }
}
