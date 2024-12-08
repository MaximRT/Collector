using API.Application.Services;
using API.Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectorController(CollectorService collectorService) : ControllerBase
    {
        private readonly CollectorService _collectorService = collectorService;

        [HttpPost("frame")]
        public async Task<IActionResult> SendFrameAsync([FromBody] Frame frame)
        {
            if (frame == null || frame.Image == null)
            {
                return BadRequest("Invalid frame data.");
            }

            var result = await _collectorService.SendFrameToAnalysService(frame);


            return StatusCode(200, "Sending...");
        }
    }
}
