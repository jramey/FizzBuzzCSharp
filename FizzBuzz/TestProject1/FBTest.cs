using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Calculate;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class FBTest
    {
        private FizzBuzz fizzbuzz;

        public FBTest()
        {
            this.fizzbuzz = new FizzBuzz();
        }

        [TestCase]
        public void returnOne()
        {
            Assert.AreEqual("1", fizzbuzz.shout(1));
        }

        [TestCase]
        public void returnTwo()
        {
            Assert.AreEqual("2", fizzbuzz.shout(2));
        }

        [TestCase]
        public void returnFizzForThree()
        {
            Assert.AreEqual("Fizz", fizzbuzz.shout(3));
        }

        [TestCase]
        public void returnFour()
        {
            Assert.AreEqual("4", fizzbuzz.shout(4));
        }

        [TestCase]
        public void returnBuzzForFive()
        {
            Assert.AreEqual("Buzz", fizzbuzz.shout(5));
        }

        [TestCase]
        public void returnFizzForNine()
        {
            Assert.AreEqual("Fizz", fizzbuzz.shout(9));
        }

        [TestCase]
        public void returnBuzzForTen()
        {
            Assert.AreEqual("Buzz", fizzbuzz.shout(10));
        }

        [TestCase]
        public void returnFizzBuzzFor15()
        {
            Assert.AreEqual("FizzBuzz", fizzbuzz.shout(15));
        }
    }
}
