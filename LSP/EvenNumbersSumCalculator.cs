using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
   public class EvenNumbersSumCalculator:SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers):base(numbers)
        {

        }
        public new int Calculate() => _numbers.Where(b => b % 2 == 0).Sum();

    }
}
