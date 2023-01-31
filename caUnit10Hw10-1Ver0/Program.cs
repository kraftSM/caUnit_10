using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw10_1_1Ver0
{
    internal class Program
    {           
        static string UnitName = "Un:10";
        static string UnDescr = "Interface.";
        static string ExName = "HW-1/2 Calculator V0";
        static string ExDescr = "Calculator Simple V0";

        static string inStr;
        static int Val1=0, Val2=0;
        static protected string UnTitle
        {
            get
            { return UnitName + "[" + UnDescr + "]"; }
        }
        static protected string ExTitle
        {
            get
            { return UnitName + "." + ExName + "[" + ExDescr + "]"; }
        }
        static protected string Promt
        {
            get
            { return UnitName + "." + ExName + ":"; }
        }
        static bool isCorInput(string inStr, ref  int val)
        {
            bool result=false;
            try
            {
                val = System.Convert.ToInt32(inStr);
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} ошибка ввода данных {1}", Promt, ex.Message);
                Console.WriteLine("{0} ошибка вводв данных {1}", Promt, ex.StackTrace);

                result = false;
                return result;
            }
            finally { 
                
            }
        }
        static void Main(string[] args)
        {
            
            Calculator Calc = new Calculator();

            Console.WriteLine("{0}|{1}:Startig ", UnTitle, ExTitle);
            Console.WriteLine("{0} ", Promt);

            do
            {
                Console.WriteLine("{0}  Введите первое слагаемое", Promt);
            }
            while (!isCorInput(Console.ReadLine(), ref Val1));
            do
            {
                Console.WriteLine("{0}  Введите второе слагаемое", Promt);
            }
            while (!isCorInput(Console.ReadLine(), ref Val2));
 
            Console.WriteLine("{0}  {1}+{2}={3}", Promt, Val1, Val2, Calc.GetResult(Val1, Val2)); 

            Console.WriteLine("\n{0}: Finishing.", ExTitle);
            Console.WriteLine("{0}: Finished.\nPress any key.", UnTitle);
            Console.ReadKey();
        }
    }
}
