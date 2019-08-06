using System;
namespace Solid.Core
{
    public class RuleFizz : IRule
    {
        public RuleFizz()
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
