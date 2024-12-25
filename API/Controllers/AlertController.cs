using API.Application.Interfaces;
using API.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AlertController(IAlertService alertService) : ControllerBase
    {
        private readonly IAlertService _alertService = alertService;

        [HttpPost("alerts")]
        public async Task<IActionResult> PostAlertAsync([FromBody] AlertPostRequest request)
        {
            try
            {
                await _alertService.PostAlertAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("alerts")]
        public async Task<IActionResult> PutAlertAsync([FromBody] AlertPostRequest request)
        {
            await _alertService.PostAlertAsync(request);
            return Ok();
        }
    }
}
