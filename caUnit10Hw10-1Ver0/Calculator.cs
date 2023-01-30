using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw10_1Ver0 
{
    internal class Calculator:ICalculator
    {
        public int GetResult(int a, int b)
        { 
            return a + b; 
        }
    }
}
