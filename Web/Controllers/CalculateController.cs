using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        private readonly ILogger<CalculateController> _logger;

        public CalculateController(ILogger<CalculateController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Add/{left}/{right}")]
        public int Add(int left, int right)
        {
            var calculator = new Calculator();
            return calculator.Sum(left, right);
        }

        [HttpGet("Subtract/{left}/{right}")]
        public int Subtract(int left, int right)
        {
            var calculator = new Calculator();
            return calculator.Subtract(left, right);
        }
    }
}