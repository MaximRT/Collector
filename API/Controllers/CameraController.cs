using API.Application.Requests;
using API.Application.Services.CameraService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CameraController(ICameraService cameraService) : ControllerBase
    {
        private readonly ICameraService _cameraService = cameraService;


        [HttpGet("/frame")]
        public async Task<IActionResult> GetFrameAsync()
        {
            return Ok();
        }

        [HttpPost("stream")]
        public async Task<IActionResult> PostStreamAsync([FromBody] CameraPostRequest request, [FromQuery] string toggle)
        {
            var result = await _cameraService.PostStreamAsync(request, toggle);

            return Ok();
        }

        [HttpPut("/config")]
        public async Task<IActionResult> PutConfigAsync([FromBody] CameraPutRequest request)
        {
            return Ok();
        }

        [HttpGet("config")]
        public async Task<IActionResult> GetConfigAsync()
        {
            //var result = await _cameraClient.GetConfigResponseAsync();
            return Ok();
        }
    }
}
