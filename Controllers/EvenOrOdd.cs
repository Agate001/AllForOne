using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EvenOrOdd : ControllerBase
    {
        private readonly OddEven _OddCheckerService;
        public EvenOrOdd(OddEven oddCheckerService)
        {
            _OddCheckerService = oddCheckerService;
        }
        [HttpGet("get/{number}")]
        public string GuessIt(int number)
        {
            return _OddCheckerService.oddEvenCheck(number);
        }
    }
}