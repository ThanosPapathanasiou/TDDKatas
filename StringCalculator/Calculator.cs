using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator {
    public class Calculator {
        private string delimiters = ",\n";

        public int Add(string numbers)
        {
            if (HasDelimiterLine(numbers))
                numbers = HandleDelimiterLine(numbers);

            if (IsEmptyString(numbers))
                return HandleEmptyString();

            if (IsMultipleNumbers(numbers))
                return HandleMultipleNumbers(numbers);

            return HandleOneNumber(numbers);
        }

        private string HandleDelimiterLine(string numbers)
        {
            delimiters += numbers[2];
            numbers = numbers.Substring(numbers.IndexOf('\n') + 1);
            return numbers;
        }

        private bool HasDelimiterLine(string numbers)
        {
            return numbers.StartsWith("//");
        }

        private static int HandleOneNumber(string numbers)
        {
            int number =  Int32.Parse(numbers);
            
            HandleNegativeNumbers(number);
            number = HandleNumbersGreaterThanOneThousand(number);

            return number;
        }

        private static int HandleNumbersGreaterThanOneThousand(int number)
        {
            if (number > 1000)
                number = 0;
            return number;
        }

        private static void HandleNegativeNumbers(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(number.ToString());
        }

        private bool IsMultipleNumbers(string numbers)
        {
            foreach(char delimiter in delimiters)
            {
                if (numbers.Contains(delimiter))
                    return true;
            }
            return false;
        }

        private int HandleMultipleNumbers(string numbers)
        {
            string[] nums = numbers.Split(delimiters.ToCharArray());
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
