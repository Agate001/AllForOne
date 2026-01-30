using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class LibMaker
    {
        public string Lib(string name, string adjective, string noun, string verb)
        {
            return $"One day, {name} found a very {adjective} {noun} and decided to {verb} it.";
        }
    }
}