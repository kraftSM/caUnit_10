using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw1_2
{
    internal interface ICalculator 
    {
            int Sum(int a, int b);
        void AddOperand(int a);
         //string GetOperators();
         string SetOperator( string opr);
         string GetResult();
    }
    
}
