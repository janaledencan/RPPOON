using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.MyMemento
{
    class BankAccountSystem
    {
        public List<BankMemento> previousStates { get; private set; }
    }
}
