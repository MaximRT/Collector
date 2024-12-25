using API.Services.CollectorService;
using Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectorController(ICollectorService collectorService) : ControllerBase
    {
        private readonly ICollectorService _collectorService = collectorService;

        [HttpPost("frame")]
        public async Task<IActionResult> SendFrameAsync([FromBody] FrameDto frameDto)
        {
            try
            {
                await _collectorService.SendFrameAsync(frameDto);

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
