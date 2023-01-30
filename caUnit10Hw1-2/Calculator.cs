using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw1_2
{
    internal class Calculator : ICalculator
    {
        enum Opr {  UnDef,  Exe,     Add,        Mul        };        
        string Operators = "+";
        Opr Operator= Opr.UnDef;
        string result = "Undefined";
        const int OprMaxIdx = 4;
        int[] Operands;
        int OprIdx= 0;
        public Calculator()
        {
            //Operator = UnDef;
            Operators = "+"; 
            Operands = new int[OprMaxIdx];

        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public string GetOperators( ) 
        {
            return Operators;
         }
        public string SetOperator(string opr)
        {
            if (CheckOperator(opr)) 
            {
                InvalidCastException(opr); 
            } Operands[OprIdx++] = opr; 
        }
        public void AddOperand(int a)
        {
            if (CheckOperand(a)) Operator = Opr.Add;
        }
        public string GetResult() { return result; }
        bool CheckOperand(string str) {
            bool result = false;
            float res;
            res = System.Convert.ToInt32(str);
            
            return result; 
        }
        bool CheckOperator(string str)
        {
            bool result = false;
            if ((str == "+")||(str == "=")) result = true;
            return result;
        }
    }
}
