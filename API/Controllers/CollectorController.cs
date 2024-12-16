using API.Application.Interfaces;
using API.Application.Requests;
using API.Domain;
using API.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectorController(ICollectorService collectorService) : ControllerBase
    {
        private readonly ICollectorService _collectorService = collectorService;

        [HttpPost("frame")]
        public async Task<IActionResult> SendFrameAsync([FromBody] Frame frame)
        {
            try
            {
                await _collectorService.SendFrameToAnalysService(frame);

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            //if (frame == null || frame.Image == null)
            //{
            //    return BadRequest("Invalid frame data.");
            //}

            
            //var result = await _collectorService.SendFrameToAnalysService(frame);


            //return StatusCode(200, result);
        }

        [HttpPost("stream")]
        public async Task<IActionResult> SendStreamAsync([FromBody] CameraPostRequest request, [FromQuery] string toggle) // Кажется тут должно быть CameraPostRequestDto
        {
            var result = await _collectorService.SendStreamAsync(request, toggle);

            return StatusCode(200, result);
        }

        [HttpPost("alerts")]
        public async Task<IActionResult> SendAlertAsync([FromBody] AlertPostRequest request)
        {
            try
            {
                await _collectorService.SendAlertAsync(request);

                return StatusCode(200); 
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            } 
        }

        [HttpPost("persons")]
        public async Task<IActionResult> SendPersonsAsync([FromBody] SectionPostPersonsRequest request)
        {
            try
            {
                await _collectorService.SendPersonsAsync(request);

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("faceRecognitionProxy/frame")]
        public async Task<IActionResult> SendFrameToFaceRecognition([FromBody] FaceRecognitionSendFrameRequest request)
        {
            try
            {
                await _collectorService.SendFrameToFaceRecognitionAsync(request);
                
                return StatusCode(200);
            }
            catch (Exception ex )
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
