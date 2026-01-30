using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class Magic8bakk
    {
       
        public string MagicResponse(string question)
        {
          string[] responses = new string[]
            {
                "Yes, definitely.",
                "Ask again later.",
                "Don't count on it.",
                "Absolutely!",
                "My sources say no.",
                "It is certain.",
                "Very doubtful.",
                "Without a doubt.",
                "Shut up",
                "Dumb question",
                "Obviously"
            };
            Random rand = new Random();
            int index = rand.Next(responses.Length);
            return responses[index];
        }
    }
}