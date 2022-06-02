using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider systemDataProvider = new SystemDataProvider();
            Logger consoleLogger = new ConsoleLogger();
            
            systemDataProvider.Attach(consoleLogger);

            while (true)
            {
                systemDataProvider.Notify();
                System.Threading.Thread.Sleep(1000);
            };
            
        }
    }
}
