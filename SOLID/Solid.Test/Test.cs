using NUnit.Framework;
using Solid.Core;
using System;
namespace Solid.Test
{
    [TestFixture()]
    public class FizzBuzzTest
    {
        [Test()]
        public void Using_Number_3_Should_Print_Fizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.ReturnValue(3);
            Assert.AreEqual("Fizz", result);
        }
    }
}
