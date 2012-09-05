using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate
{
    public class FizzBuzz
    {
        public string shout(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";
            else if (i % 5 == 0)
                return "Buzz";
            else if (i % 3 == 0)
                return "Fizz";

            return i.ToString();

        }
    }
}
