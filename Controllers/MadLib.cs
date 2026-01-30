using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLib : ControllerBase
    {    
        private readonly LibMaker _libMakerService;
        public MadLib(LibMaker libMakerService)
        {
            _libMakerService = libMakerService;
        }
        [HttpGet("get/{name}/{adjective}/{noun}/{verb}")]
        public string SayHello(string name, string adjective, string noun, string verb)
        {
            return _libMakerService.Lib(name, adjective, noun, verb);
        }
    }
}