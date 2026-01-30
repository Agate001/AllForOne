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
    public class AskingQuestion : ControllerBase
    {
        private readonly Questions _questionsService;
        public AskingQuestion(Questions questionsService)
        {
            _questionsService = questionsService;
        }
        [HttpGet("get/{name}/{favoritebook}")]
        public string GuessIt(string name, string favoritebook)
        {
            return _questionsService.getQuestions(name, favoritebook);
        }
    }
}