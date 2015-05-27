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

    }
}
