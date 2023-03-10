using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw2_2Ver0
{
    internal class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error:,\t" + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Event:,\t" + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        void ILogger.Exception(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exept:,\t" + ex.Message);
            Console.WriteLine("Exept:,\t" +ex.StackTrace);
            Console.ForegroundColor = ConsoleColor.White;
        }

    
        public void Message(string message)
        {
            Console.WriteLine("Msg__:,\t" + message); 
        }   
                      
    }

}        
