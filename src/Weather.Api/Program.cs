using Weather.Model;

namespace Weather.Api;

public class Program
{
    public static Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        ConfigureServices(builder.Services, builder.Environment);
        var app = builder.Build();
        return ConfigureApp(app);
    }


    private static void ConfigureServices(
        IServiceCollection services,
        IWebHostEnvironment environment)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddSingleton<IWeatherDataContext, WeatherDataContext>();
    }

    private static Task ConfigureApp(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapControllers();

        return app.RunAsync();
    }
}