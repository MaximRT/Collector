using API.Application.Clients;
using RestSharp;

namespace CollectorService.Services
{
    public class CollectorService
    {
        private readonly ImageAnalysisClient _imageAnalysisClient;
        public CollectorService(ImageAnalysisClient imageAnalysisClient ) 
        {
            _imageAnalysisClient = imageAnalysisClient;
        }


       

        //private async Task<IResponse> GetResponse(string url, Frame frame)
        //{
        //    var client = new RestClient(url);

        //    var request = new RestRequest()
        //    {
        //        Method = Method.Post,
        //        RequestFormat = DataFormat.Json
        //    };

        //    request.AddBody(frame);

        //    try
        //    {
        //        var response = await client.ExecuteAsync<FaceRecognitionResponse>(request);
                
        //        if (response.IsSuccessful && response.Data != null)
        //        {
        //            return response.Data;
        //        }

        //        return response.Data;
        //    }
        //    catch (Exception ex)
        //    {
        //        return new FaceRecognitionResponse();
        //    }
        }
    }
