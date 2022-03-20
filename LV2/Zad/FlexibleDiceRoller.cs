using System;
using System.Collections.Generic;
using System.Text;

namespace Zad
{
    internal class FlexibleDiceRoller:IDiceRoller, IManageDice
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }



        public string GetStringRepresentation()
        {
            StringBuilder sb = new StringBuilder();

            foreach (int result in this.resultForEachRoll)
            {
                sb.Append(result + " ");
            }
            return sb.ToString();
        }
    }
}
