using System;
using System.Collections.Generic;
using System.Text;

namespace Cursor.Task2
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
