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

            foreach (Die result in this.dice)
            {
                sb.Append(result.GetNumberOfSides() + " ");
            }
            return sb.ToString();
        }

        //U klasu FlexibleDiceRoller dodati metodu koja uklanja samo kockice čiji broj stranica odgovara predanom joj argumentu.
        public void DeleteCorrespondingDie(int numberOfSides)
        {
            for(int i = dice.Count - 1; i >= 0 ; i--)
            {
                if(numberOfSides == dice[i].GetNumberOfSides())
                {
                    dice.RemoveAt(i);
                }
            }
            
        }
    }
}
