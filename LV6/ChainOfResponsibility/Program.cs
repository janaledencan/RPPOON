using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =
            new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            //5.
            logger.SetNextLogger(fileLogger);
            logger.SetNextLogger(new ConsoleLogger(MessageType.WARNING));
            
            logger.Log("Hello, it's me...", MessageType.WARNING);

            //6.

        }
    }
}
