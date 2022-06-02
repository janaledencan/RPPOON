using System;
using System.Collections.Generic;
using System.Text;

namespace Visitant
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
