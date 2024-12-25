using API.Application.Interfaces;
using API.Application.Services;
using API.Application.Services.AlertService;
using API.Application.Services.AlertService.AlertClient;
using API.Application.Services.CameraService;
using API.Application.Services.CameraService.CameraClient;
using API.Application.Services.FaceRecognitionService;
using API.Application.Services.FaceRecognitionService.FaceRecognitionClient;
using API.Services;
using API.Services.CollectorService;
using API.Services.ImageAnalysisClient;
using API.Services.SectionService;
using API.Services.SectionService.SectionClient;
using Application.Core;

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
            builder.Services.AddScoped<ISectionClient, SectionClient>();
            builder.Services.AddScoped<ISectionService, SectionService>();
            builder.Services.AddScoped<IFaceRecognitionClient, FaceRecognitionClient>();
            builder.Services.AddScoped<IFaceRecognitionService, FaceRecognitionService>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(MappingProfiles));
            
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Collector API v1");
                    c.RoutePrefix = "swagger"; 
                });
            }

            app.UseAuthorization();
            
            app.MapControllers();

            app.Run();
        }
    }
}
