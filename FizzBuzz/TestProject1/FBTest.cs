using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate;

namespace TestProject1
{
    [TestClass]
    public class FBTest
    {
        private FizzBuzz fizzbuzz;

        public FBTest()
        {
            this.fizzbuzz = new FizzBuzz();
        }

        [TestMethod]
        public void returnOne()
        {
            Assert.AreEqual("1", fizzbuzz.shout(1));
        }

        [TestMethod]
        public void returnTwo()
        {
            Assert.AreEqual("2", fizzbuzz.shout(2));
        }

        [TestMethod]
        public void returnFizzForThree()
        {
            Assert.AreEqual("Fizz", fizzbuzz.shout(3));
        }

        [TestMethod]
        public void returnFour()
        {
            Assert.AreEqual("4", fizzbuzz.shout(4));
        }

        [TestMethod]
        public void returnBuzzForFive()
        {
            Assert.AreEqual("Buzz", fizzbuzz.shout(5));
        }

        [TestMethod]
        public void returnFizzForNine()
        {
            Assert.AreEqual("Fizz", fizzbuzz.shout(9));
        }

        [TestMethod]
        public void returnBuzzForTen()
        {
            Assert.AreEqual("Buzz", fizzbuzz.shout(10));
        }

        [TestMethod]
        public void returnFizzBuzzFor15()
        {
            Assert.AreEqual("FizzBuzz", fizzbuzz.shout(15));
        }
    }
}
