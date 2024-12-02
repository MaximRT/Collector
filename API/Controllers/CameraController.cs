using API.Application.Requests;
using API.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CameraController(CameraService _service) : ControllerBase
    {

        [HttpGet("/frame")]
        public async Task<IActionResult> GetFrameAsync()
        {
            return Ok();
        }

        [HttpPost("stream")]
        public async Task<IActionResult> PostStreamAsync([FromBody] CameraPostRequest request, [FromQuery] string toggle)
        {
            var result = await _service.SendFrameObjects(request, toggle);

            return Ok(result);
        }

        [HttpPut("/config")]
        public async Task<IActionResult> PutConfigAsync([FromBody] CameraPutRequest request)
        {
            return Ok();
        }

        [HttpGet("/config")]
        public async Task<IActionResult> GetConfigAsync()
        {
            return Ok();
        }
    }
}
