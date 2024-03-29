﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad
{
    internal class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;

        public int GetNumberOfSides()
        {
            return numberOfSides;
        }


        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
