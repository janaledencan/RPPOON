using System;
using System.Collections.Generic;
using System.Text;

//1.zad Kreirajte objekt klase DiceRoller i u njega ubacite 20 kockica. Baciti sve kockice i ispisati rezultate bacanja kockica na ekran.
namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            const int numberOfDice= 20;
            DiceRoller diceRoller = new DiceRoller();
            

            int i;
            for(i=0; i < numberOfDice; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }

            diceRoller.RollAllDice();
            

            StringBuilder stringBuilder = new StringBuilder();
            IList<int> rollingResults = diceRoller.GetRollingResults();

            foreach(int rollingResult in rollingResults)
            {
                stringBuilder.Append(rollingResult.ToString()+ ", ");
            }

            Console.WriteLine(stringBuilder.ToString());

            
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(diceRoller);
            /* diceRoller.SetLogger(consoleLogger);
            diceRoller.LogRollingResults();*/



            FlexibleDiceRoller flexibleDiceRoller = new FlexibleDiceRoller();

            for (i = 0; i < numberOfDice - 10; i++)
            {
                flexibleDiceRoller.InsertDie(new Die(6));
                flexibleDiceRoller.InsertDie(new Die(3));
            }
            flexibleDiceRoller.RollAllDice();
            Console.WriteLine(flexibleDiceRoller.GetStringRepresentation());

            flexibleDiceRoller.DeleteCorrespondingDie(6);
            Console.WriteLine(flexibleDiceRoller.GetStringRepresentation());
        }
    }
}
