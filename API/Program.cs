
using API.Application.Clients;
using API.Application.Services;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddScoped<CameraService>();
            builder.Services.AddScoped<CameraClient>();
            builder.Services.AddScoped<CollectorService>();
            builder.Services.AddScoped<ImageAnalysisService>();
            builder.Services.AddScoped<ImageAnalysisClient>();

            var app = builder.Build();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
