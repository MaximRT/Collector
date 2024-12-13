using API.Application.Requests;
using API.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageAnalysisController(ImageAnalysisService imageAnalysisService) : ControllerBase
    {
        private readonly ImageAnalysisService _imageAnalysisService = imageAnalysisService;

        [HttpPost("frame")]
        public async Task<IActionResult> PostFrameAsync([FromBody] ImageAnalysisRequest request)
        {
            var result = await _imageAnalysisService.SendFrameAsync(request);
            
            return Ok(result);
        }
    }
}
