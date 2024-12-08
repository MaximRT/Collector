using API.Application.Requests;
using API.Application.Responses;
using API.Domain;

namespace API.Application.Services
{
    public class CollectorService
        (CameraService cameraService, ImageAnalysisService imageAnalysisService) 
    {
        private readonly CameraService _cameraService = cameraService;
        private readonly ImageAnalysisService _imageAnalysisService = imageAnalysisService;

        public async Task<ImageAnalysisResponse> SendFrameToAnalysService(Frame frame)
        {
            var request = new ImageAnalysisRequest()
            {
                TimeStamp = frame.Timestamp,
                Image = frame.Image,
                Section = frame.Section,
                Event = frame.Event,
                Destination = frame.Destination,
                FrameId = frame.FrameId
            };

           return await _imageAnalysisService.SendFrameAsync(request);
        } 
    }
}
