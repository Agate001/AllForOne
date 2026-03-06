using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class OddEven
    {
        public string OddEvenCheck(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is even.";
            }

            return $"{number} is odd.";
        }
    }
}