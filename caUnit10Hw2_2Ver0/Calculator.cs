using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace caUnit10Hw2_2Ver0
{
    internal class Calculator:ICalculator
    {
        static Logger Log;
        static string val1;
        static string val2;
        static string opr;
        static string res;
        static string EventMsg
        {
            get
            { return val1 + " " + opr + " " + val2 + " = " + res; }
        }
        public Calculator(Logger log)  { Log = log; }
         public int GetResult(int a, int b)
        {
            val1=a.ToString();
            val2=b.ToString();
            opr = "+";
            var result = a + b;
            res = result.ToString();  
            //EventMsg = a.ToString + "}+{" + b.ToString + "}={" + result.ToString;
            Log.Event(EventMsg); 
            return result; 
        }
    }
}
