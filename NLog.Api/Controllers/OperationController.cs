using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog.Api.Model;

namespace NLog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationController : ControllerBase
    {

        private readonly ILogger<OperationController> _logger;

        public OperationController(ILogger<OperationController> logger)
        {
            _logger = logger;
            _logger.LogDebug(999, $"NLog injected into {nameof(OperationController)}");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hi" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] LogModel logModel)
        {
            _logger.LogError(logModel.Codigo, logModel.Message, logModel.StackTrace);

            return Ok();
        }
    }
}
