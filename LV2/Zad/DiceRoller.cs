﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad
{
    internal class DiceRoller:ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        //private ILogger logger;

        /*public void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }*/

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //clear results of previous rolling
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        //View of the results
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
            this.resultForEachRoll
            );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }

      /*  public void LogRollingResults()
        {
            
        }*/

        public string GetStringRepresentation()
        {
            StringBuilder sb = new StringBuilder();

            foreach(int result in this.resultForEachRoll)
            {
                sb.Append(result);
            }
            return sb.ToString();
        }
    }
}
