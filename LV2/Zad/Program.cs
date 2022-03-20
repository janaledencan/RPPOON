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
            Random randomGenerator = new Random();

            int i;
            for(i=0; i < numberOfDice; i++)
            {
                diceRoller.InsertDie(new Die(6,randomGenerator));
            }

            diceRoller.RollAllDice();
            

            StringBuilder stringBuilder = new StringBuilder();
            IList<int> rollingResults = diceRoller.GetRollingResults();

            foreach(int rollingResult in rollingResults)
            {
                stringBuilder.Append(rollingResult.ToString()+ ", ");
            }

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}
