using AllForOne.services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EvenOrOdd : ControllerBase
    {
        private readonly OddEven _oddCheckerService;

        public EvenOrOdd(OddEven oddCheckerService)
        {
            _oddCheckerService = oddCheckerService;
        }

        [HttpGet("get/{number}")]
        public string CheckNumber(int number)
        {
            return _oddCheckerService.OddEvenCheck(number);
        }
    }
}