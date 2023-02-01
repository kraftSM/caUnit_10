using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw2_2
{
    internal class Calculator : ICalculator
    {
        public delegate void CalculatortHandler(string message);
        public static event CalculatortHandler evCalc;

        static int[] Values;
        static Logger Log;
        int oprIdx = 0;
        string opr = "";
        //public Calculator (Logger log)
        public Calculator( )
        {
             //Log = log;
            Values =new int[3];  
        }
        public int GetResult()
        {
            
            evCalc?.Invoke($"{Values[1]} {opr} {Values[2]} = {Values[0]}"); 
            return Values[0];         
        }

        public void SetOperand(int val, int opIdx)
        {
            //opIdx=0 результат операции
            //opIdx=1...2 операнды для операции
            if ((opIdx > 0) & (opIdx < Values.Length)) 
            {
                Values[opIdx] = val;
                evCalc?.Invoke($"Value of argument Arg{opIdx} is set to {val}");                
            }
                
        }

        public void SetOperation( int oprIdx=0)
        {
            
            switch (oprIdx) 
            {
                case 0:
                    Values[0] = Values[1] + Values[2]; opr = "+"; break; 
                case 1:
                    Values[0] = Values[1] - Values[2]; opr = "-"; break;
                case 2:
                    Values[0] = Values[1] * Values[2]; opr = "*"; break;
                default:
                    Values[0] = Values[1] + Values[2]; opr = "+"; break;
            }
            evCalc?.Invoke($"Value jf operation  is set to {opr}");

        }

        public string GetOperators()
        {
            return "+-*";
        }
    }
}
