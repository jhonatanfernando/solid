using System;
namespace Solid.Core
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string ReturnValue(int number)
        {
            if (number % 3 == 0)
                return "Fizz";

            return number.ToString();
        }
    }
}
