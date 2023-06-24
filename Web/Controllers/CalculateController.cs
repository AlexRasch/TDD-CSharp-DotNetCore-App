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
            return new Calculator().Sum(left, right);
        }

        [HttpGet("Subtract/{left}/{right}")]
        public int Subtract(int left, int right)
        {
            return new Calculator().Subtract(left, right);
        }
    }
}