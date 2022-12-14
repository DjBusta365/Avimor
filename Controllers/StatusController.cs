using Microsoft.AspNetCore.Mvc;

namespace AvimorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<StatusController> _logger;

        public StatusController(ILogger<StatusController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Status")]
        public async Task<IActionResult> GetStatus()
        {
            return Ok();
        }
    }
}