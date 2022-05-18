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
            StringChecker stringChecker = new StringDigitChecker();
            StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();

            stringChecker.SetNext(upperCaseChecker);
            Console.WriteLine(upperCaseChecker.Check("We are the heros..."));
            Console.WriteLine(stringChecker.Check("123 223 323..."));   //IT DOESN'T WORK AS IT SHOULD

            //7.
            PasswordValidator passwordValidator = new PasswordValidator(stringChecker);
            passwordValidator.SetNext(new StringLowerCaseChecker());

            Console.WriteLine(passwordValidator.ValidatePassword("MyNameIs NOOO 123"));
        }
    }
}
