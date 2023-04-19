using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsoleEnd
{
    public class FizzBuzzRefactored
    {
        public string WriteFizzBuzz(long num)
        {
            if (IsDivisibleBy(num, 3) && IsDivisibleBy(num, 5))
                return "FizzBuzz";
            else if (IsDivisibleBy(num, 3))
                return "Fizz";
            else if (IsDivisibleBy(num, 5))
                return "Buzz";
            else
                return num.ToString();
        }

        private static bool IsDivisibleBy(long numToCheck, int divisibleBy)
        {
            if (numToCheck % divisibleBy == 0)
                return true;
            else 
                return false;
        }
    }
}
