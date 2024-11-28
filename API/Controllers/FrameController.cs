using CollectorService.Enums;
using CollectorService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CollectorService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FrameController : ControllerBase
    {
        private readonly IService _service;
        public FrameController(IService service)
        {
            _service = service;
        }

        [HttpPost("frame")]
        public async Task<IActionResult> SendFrameAsync([FromBody] Frame frame)
        {
            if (frame == null || frame.Image == null)
            {
                return BadRequest("Invalid frame data.");
            }

            await _service.Send(ServiceDestinationEnum.Image, frame);

            return StatusCode(200, "Sending...");
        }
    }
}
