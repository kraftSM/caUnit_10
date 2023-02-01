using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw2_2

{
    internal class Program
    {
        static string UnitName = "Un:10";
        static string UnDescr = "Interface.";
        static string ExName = "HW-2/2 Calculator+";
        static string ExDescr = "Calculator/Logger";

        static string inStr;
        static int Val1 = 0, Val2 = 0;

        static Calculator Calc;
        static Logger Log;
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
        static void Main(string[] args)
        {
            Console.WriteLine("{0}|{1}:Startig ", UnTitle, ExTitle);
            Console.WriteLine("{0} ", Promt);
            
            Log = new Logger();
            //Calc = new Calculator(Log);
            Calc = new Calculator();

            Calculator.evCalc += Log.Event;

            do
            {
                Console.WriteLine("{0}  Введите первый операнд (целое число)", Promt);
            }
            while (!isCorInput(Console.ReadLine(), ref Val1));
            Calc.SetOperand(Val1, 1);
            do
            {
                Console.WriteLine("{0}  Введите второй операнд (целое число)", Promt);
            }
            while (!isCorInput(Console.ReadLine(), ref Val2));
            Calc.SetOperand(Val2, 2);
            
            //Calc.SetOperation(0);//пользователь выбора операции не делает (пока) задаем здесь
            Console.WriteLine("{0}  Выберите операцию {1} ", Promt, Calc.GetOperators());
            var userEntry = Console.ReadLine();
            try
            {
                switch (userEntry)
                {
                    case "-": Calc.SetOperation(1); break;
                    case "*": Calc.SetOperation(2); break;
                    case "+": Calc.SetOperation(0); break;
                    default: Calc.SetOperation(0); break;
                }
            }
            catch (Exception ex)
            {
                ((ILogger)Log).Exception(ex);
            }
            

            Calc.GetResult();


            Console.WriteLine("\n{0}: Finishing.", ExTitle);
            Console.WriteLine("{0}: Finished.\nPress any key.", UnTitle);
            Console.ReadKey();
        }
        static bool isCorInput(string inStr, ref int val)
        {
            bool result = false;
            try
            {
                val = System.Convert.ToInt32(inStr);
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("{0} ошибка ввода данных {1}", Promt, ex.Message);
                //Console.WriteLine("{0} ошибка вводв данных {1}", Promt, ex.StackTrace);
                ((ILogger)Log).Exception(ex);

                result = false;
                return result;
            }
            finally
            {

            }
        }
    }
}
