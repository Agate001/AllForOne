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
    public class ReverseItNum : ControllerBase
    {
        private readonly NumberReverse _NumberReverse;
        public ReverseItNum(NumberReverse numberReverse)
        {
            _NumberReverse = numberReverse;
        }
        [HttpGet("get/{input}")]
        public int GetAnswer(int input)
        {
            return _NumberReverse.reverseNum(input);
        }
    }
}