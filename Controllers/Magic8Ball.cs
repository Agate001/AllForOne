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
    public class Magic8Ball : ControllerBase
    {
        private readonly Magic8bakk _magic8bakkService;
        public Magic8Ball(Magic8bakk magic8bakkService)
        {
            _magic8bakkService = magic8bakkService;
        }
        [HttpGet("get/{question}")]
        public string GetAnswer(string question)
        {
            return _magic8bakkService.MagicResponse(question);
        }
    }
}