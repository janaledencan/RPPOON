using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class CareTaker
    {
        public Memento PreviousState { get; set; }

        public List<Memento> PreviousStates { get; set; }
    }
}
