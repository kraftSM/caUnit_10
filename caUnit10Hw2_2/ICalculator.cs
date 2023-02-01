using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw2_2
{
    internal interface ICalculator
    {
        int GetResult();
        string GetOperators();
        void SetOperand(int val, int opIdx);
        void SetOperation(int oprIdx=0);

    }
}
