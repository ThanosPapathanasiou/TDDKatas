using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator.Tests {
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calc;

        [SetUp]
        public void NewCalc()
        {
             calc = new Calculator();
        }

        [Test]
        public void Add_Given_EmptyString_Returns_Zero()
        {
            int result = calc.Add("");
            Assert.AreEqual(result, 0);
        }

        [TestCase("1",1)]
        [TestCase("99", 99)]
        public void Add_Given_OneNumber_Returns_Number(string numbers, int expected)
        {
            int result = calc.Add(numbers);
            Assert.AreEqual(result, expected);
        }

        [TestCase("1,2",3)]
        [TestCase("4,5", 9)]
        public void Add_Given_TwoNumbers_Returns_SumOfNumbers(string numbers, int expected)
        {
            int result = calc.Add(numbers);
            Assert.AreEqual(result, expected);
        }
        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4,5,6", 21)]
        public void Add_Given_ManyNumbers_Returns_SumOfNumbers(string numbers, int expected)
        {
            int result = calc.Add(numbers);
            Assert.AreEqual(result, expected);
        }

        [TestCase("1,2\n3", 6)]
        [TestCase("1\n2,3", 6)]
        public void Add_Given_TwoNumbers_UsingDifferentDelimiters_Returns_SumOfNumbers(string numbers, int expected)
        {
            int result = calc.Add(numbers);
            Assert.AreEqual(result, expected);
        }

        [TestCase("//;\n", 0)]
        [TestCase("//;\n1", 1)]
        [TestCase("//;\n1,2", 3)]
        [TestCase("//;\n1,2\n3;4", 10)]
        public void Add_Given_NewDelimiter_Returns_SumOfNumbers(string numbers, int expected)
        {
            int result = calc.Add(numbers);
            Assert.AreEqual(result, expected);
        }


    }
}
