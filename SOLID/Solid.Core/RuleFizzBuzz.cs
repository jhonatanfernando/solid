using System;
namespace Solid.Core
{
    public class RuleFizzBuzz : IRule
    {
        public string ReturnValue(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            return number.ToString();
        }
    }
}
