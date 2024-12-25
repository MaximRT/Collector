using API.Application.Requests;
using API.Application.Responses;
using API.Requests;
using API.Services.SectionService.Requests;
using Application.Dto;

namespace API.Services.CollectorService
{
    public interface ICollectorService
    {
        Task SendFrameAsync(FrameDto frameDto);

        Task<CameraPostResponse> SendStreamAsync(CameraPostRequest request, string toggle);

        Task SendAlertAsync(AlertPostRequest request);

        Task SendPersonsAsync(SectionPostPersonsRequest request);
        //Task<FaceRecognitionSendFrameResponse>  SendFrameToFaceRecognitionAsync(FaceRecognitionSendFrameRequest request);

        Task SendFrameToFaceRecognitionAsync(FaceRecognitionSendFrameRequest request);
    }
}
