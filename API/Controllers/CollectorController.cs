using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Services;
using API.Domain;
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
            if (frame == null || frame.Image == null)
            {
                return BadRequest("Invalid frame data.");
            }

            var result = await _collectorService.SendFrameToAnalysService(frame);


            return StatusCode(200, result);
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
            await _collectorService.SendAlertAsync(request);

            return StatusCode(200); // Нужен ли тут try ..catrh? пупу
        }
    }
}
