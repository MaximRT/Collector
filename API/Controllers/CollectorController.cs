using API;
using API.Application.Enums;
using API.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CollectorService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectorController() : ControllerBase
    {

        [HttpPost("frame")]
        public async Task<IActionResult> SendFrameAsync([FromBody] Frame frame)
        {
            if (frame == null || frame.Image == null)
            {
                return BadRequest("Invalid frame data.");
            }

            //var result = await _service.SendAsync<CameraGetResponse>("CameraService", HttpMethodEnum.Get);


            return StatusCode(200, "Sending...");
        }
    }
}
