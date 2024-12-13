using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Responses;
using API.Domain;

namespace API.Application.Services
{
    public class CollectorService
        (ICameraService cameraService, IImageAnalysisService imageAnalysisService, IAlertService alertService) : ICollectorService
    {
        private readonly ICameraService _cameraService = cameraService;
        private readonly IImageAnalysisService _imageAnalysisService = imageAnalysisService;
        private readonly IAlertService _alertService = alertService;

        public async Task SendAlertAsync(AlertPostRequest request)
        {
            await _alertService.PostAlertAsync(request);
        }

        public async Task<ImageAnalysisResponse> SendFrameToAnalysService(Frame frame)
        {
            var request = new ImageAnalysisRequest()
            {
                TimeStamp = frame.Timestamp,
                Image = frame.Image,
                Section = frame.Section,
                Event = frame.Event,
                FrameId = frame.FrameId
            };

           return await _imageAnalysisService.SendFrameAsync(request);
        }

        public async Task<CameraPostResponse> SendStreamAsync(CameraPostRequest request, string toggle)
        {
            return await _cameraService.PostStreamAsync(request, toggle);
        }

        
    }
}
