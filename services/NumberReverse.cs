using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne.services
{
    public class NumberReverse
    {
        public int reverseNum(int input)
        {
            char[] charArray = input.ToString().ToCharArray();
            Array.Reverse(charArray);
            return int.Parse(new string(charArray));
        }
    }
}