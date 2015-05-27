using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator {
    public class Calculator {
        private char separator = ',';

        public int Add(string numbers)
        {
            if (IsEmptyString(numbers))
                return HandleEmptyString();

            if (IsMultipleNumbers(numbers))
                return HandleMultipleNumbers(numbers);

            return HandleOneNumber(numbers);
        }

        private static int HandleOneNumber(string numbers)
        {
            return Int32.Parse(numbers);
        }

        private bool IsMultipleNumbers(string numbers)
        {
            return numbers.Contains(separator);
        }



        private int HandleMultipleNumbers(string numbers)
        {
            string[] nums = numbers.Split(separator);
            return nums.Sum(num => HandleOneNumber(num));
        }


        private bool IsEmptyString(string numbers)
        {
            return numbers == "";
        }

        private int HandleEmptyString()
        {
            return 0;
        }
    }
}
