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
    public class Guess : ControllerBase
    {
        private readonly GuessIt _GuessIt;
        public Guess(GuessIt guessit)
        {
            _GuessIt = guessit;
        }
        [HttpGet("get/{difficulty}/{guess}")]
        public string GuessIt(string difficulty, int guess)
        {
            return _GuessIt.guess
            (difficulty, guess);
        }
    }
}