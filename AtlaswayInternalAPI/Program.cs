using AtlaswayInternalAPI.Authentication;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using Microsoft.EntityFrameworkCore;

namespace AtlaswayInternalAPI;


public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        string connectionString = builder.Configuration.GetConnectionString("AtlaswayManagement")!;

        // Add services to the container.
        builder.Services
            .AddDbContext<AtlaswayInternalDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), (optionsBuilder) =>
                {
                    optionsBuilder.EnableStringComparisonTranslations();
                });
            });

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                configPolicy => configPolicy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
        });

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddScoped<ApiKeyAuthFilter>();

        WebApplication app = builder.Build();

        app.UseRouting();

        app.UseCors("CorsPolicy");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
