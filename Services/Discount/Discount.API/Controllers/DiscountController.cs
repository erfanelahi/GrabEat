using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Discount.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly ILogger<DiscountController> _logger;
        public DiscountController(ILogger<DiscountController> logger) 
        { 
            _logger = logger;
        }
    }
}
