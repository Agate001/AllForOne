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
    public class AddTwoNumbers : ControllerBase
    {
        private readonly Addition _AdditionService;
        public AddTwoNumbers(Addition additionService)
        {
            _AdditionService = additionService;
        }
        [HttpGet("get/{num1}/{num2}")]
        public int GuessIt(int num1, int num2)
        {
            return _AdditionService.addNumbers(num1, num2);
        }
    }
}