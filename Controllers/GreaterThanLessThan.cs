using Microsoft.AspNetCore.Mvc;
using AllForOne.services;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterThanLessThan : ControllerBase
    {
        private readonly GreaterLessThan _greaterLessThanService;

        public GreaterThanLessThan(GreaterLessThan greaterLessThanService)
        {
            _greaterLessThanService = greaterLessThanService;
        }

        [HttpGet("compare/{num1}/{num2}")]
        public string Compare(double num1, double num2)
        {
            return _greaterLessThanService.ReturnStatements(num1, num2);
        }
    }
}