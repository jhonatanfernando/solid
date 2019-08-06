using System;
namespace Solid.Core
{
    public class RuleNumber : IRule
    {
        public string ReturnValue(int number)
        {
            return number.ToString();
        }
    }
}
