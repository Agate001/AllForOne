using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class Questions
    {
        public string getQuestions(string name, string favoritebook)
        {
            return $"Hello, {name}! {favoritebook} is trash.";
        }
    }
}