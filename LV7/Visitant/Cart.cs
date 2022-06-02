using System;
using System.Collections.Generic;
using System.Text;

namespace Visitant
{
    class Cart
    {
        private List<IItem> products;

        public Cart()
        {
            products = new List<IItem>();
        }

        public void Add(IItem product)
        {
            products.Add(product);
        }
        
        public void Remove(IItem product)
        {
            products.Remove(product);
        }
            
        public double Accept(IVisitor visitor)
        {
            double sum = 0;

            for(int i=0; i<products.Count; i++)
            {
                sum += products[i].Accept(visitor);
            }

            return sum;
        }

    }
}
