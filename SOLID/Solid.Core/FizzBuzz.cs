using System;
namespace Solid.Core
{
    public class FizzBuzz
    {
        private IRule _rule;

        public FizzBuzz(IRule rule)
        {
            _rule = rule;
        }

        public string ReturnValue(int number)
        {
            return _rule.ReturnValue(number);
        }
    }
}
