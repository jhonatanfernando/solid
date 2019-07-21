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

        [Test()]
        public void Using_Number_4_Should_Print_4()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.ReturnValue(4);
            Assert.AreEqual("4", result);
        }

        [Test()]
        public void Using_Number_5_Should_Print_Buzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.ReturnValue(5);
            Assert.AreEqual("Buzz", result);
        }
    }
}
