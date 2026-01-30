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
    public class HelloWorld : ControllerBase
    {
        private readonly SayHello _sayHelloService;
        public HelloWorld(SayHello sayHelloService)
        {
            _sayHelloService = sayHelloService;
        }
        [HttpGet("get/{name}")]
        public string SayHello(string name)
        {
            return _sayHelloService.getGreet(name);
        }
        
    }
}