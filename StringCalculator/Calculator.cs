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
