﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LSP
{
  public  class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
    }
}
