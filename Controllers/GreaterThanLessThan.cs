using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne.services;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterThanLessThan : ControllerBase
    {
        private readonly Greaterlessthan _greaterLessThanService;

        public GreaterThanLessThan(Greaterlessthan greaterLessThanService)
        {
            _greaterLessThanService = greaterLessThanService;
        }

        [HttpGet("compare/{input1}/{input2}")]
        public string Compare(string input1, string input2)
        {
            return _greaterLessThanService.ReturnStatements(input1, input2);
        }
    }
}
