using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caUnit10Hw2_2Ver0
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
        void Message(string message);
        void Exception (Exception ex); 
    }
}
