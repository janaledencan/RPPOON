using System;
using System.Collections.Generic;
using System.Text;

namespace Zad
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(ILogable data)
        {
             Console.WriteLine(data.GetStringRepresentation()); 
        }
    }
}
