using System;
namespace Solid.Core
{
    public class RuleBuzz : IRule
    {


        public string ReturnValue(int number)
        {
            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
