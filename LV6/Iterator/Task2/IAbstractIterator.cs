using System;
using System.Collections.Generic;
using System.Text;

namespace Cursor.Task2
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
