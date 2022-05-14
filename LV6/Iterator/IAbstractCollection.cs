using System;
using System.Collections.Generic;
using System.Text;

namespace Cursor
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
