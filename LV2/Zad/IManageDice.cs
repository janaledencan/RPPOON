using System;
using System.Collections.Generic;
using System.Text;

namespace Zad
{
    internal interface IManageDice
    {
        void InsertDie(Die die);
        void RemoveAllDice();
    }
}
