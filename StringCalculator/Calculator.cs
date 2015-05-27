using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator {
    public class Calculator {
        public int Add(string numbers)
        {
            if (IsEmptyString(numbers))
                return HandleEmptyString();

            if (numbers.Contains(','))
            {
                return Int32.Parse(numbers.Split(',')[0]) + 
                       Int32.Parse(numbers.Split(',')[1]);

            }
                

            return Int32.Parse(numbers);
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
