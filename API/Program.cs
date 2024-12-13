
using API.Application.Clients;
using API.Application.Interfaces;
using API.Application.Services;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddScoped<ICameraService, CameraService>();
            builder.Services.AddScoped<ICameraClient, CameraClient>();
            builder.Services.AddScoped<ICollectorService, CollectorService>();
            builder.Services.AddScoped<IImageAnalysisService, ImageAnalysisService>();
            builder.Services.AddScoped<IImageAnalysisClient, ImageAnalysisClient>();
            builder.Services.AddScoped<IAlertService, AlertService>();
            builder.Services.AddScoped<IAlertClient, AlertClient>();

            var app = builder.Build();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
