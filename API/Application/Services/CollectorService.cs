using API.Application.Clients;
using API.Application.Enums;
using API.Application.Responses;

namespace CollectorService.Services
{
    public class CollectorService
        (
        ImageAnalysisClient _imageAnalysisClient, CameraClient _cameraClient,
        SectionClient _sectionClient, FaceRecognitionClient _faceRecognitionClient, AlertClient _alertClient
        ) 
    {
        //public async Task<CameraGetResponse> GetFrameAsync(string serviceName, HttpMethodEnum httpMethod)
        //{
        //    return  _cameraClient.PostFramesAsync(, HttpMethodEnum.Get);
        //}

        public Task<T> SendAsync<T>(string serviceName, HttpMethodEnum httpMethod)
        {
            throw new NotImplementedException();
        }
    }
}
