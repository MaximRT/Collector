using API.Application.Requests;
using API.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageAnalysisController(ImageAnalysisService service) : ControllerBase
    {
        private readonly ImageAnalysisService _service = service;

        [HttpPost("frame")]
        public async Task<IActionResult> PostFrameAsync([FromBody] ImageAnalysisRequest request)
        {
            var result = await _service.SendFrameAsync(request);
            
            return Ok(result);
        }
    }
}
