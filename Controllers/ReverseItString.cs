using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllForOne.services;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItString : ControllerBase
    {
        private readonly StringReverse _stringReverse;

        public ReverseItString(StringReverse stringReverse)
        {
            _stringReverse = stringReverse;
        }

        [HttpGet("get/{input}")]
        public string GetAnswer(string input)
        {
            return _stringReverse.reverseString(input);
        }
    }
}
