using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class SayHello
    {
        public string getGreet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}