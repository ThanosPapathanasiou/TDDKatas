using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator {
    public class Calculator {
        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;

            return Int32.Parse(numbers);
        }
    }
}
