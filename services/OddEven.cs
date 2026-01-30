using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class OddEven
    {
        public string oddEvenCheck(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is even.";
            }
            else
            {
                return $"{number} is odd.";
            }
        }
    }
}