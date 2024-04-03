using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AggregatorController : ControllerBase
    {
        private readonly ILogger<AggregatorController> _logger;
        public AggregatorController(ILogger<AggregatorController> logger) 
        { 
            _logger = logger;
        }
    }
}
