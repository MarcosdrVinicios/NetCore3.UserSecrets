using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace UserSecrets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IOptions<Security> _config;

        public HomeController(IOptions<Security> config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var security = _config.Value;

            return Ok(security);
        }
    }
}
