using System;
using System.Collections.Generic;
using System.Text;

/*Dodati klasu Cart koja predstavlja kolekciju/agregaciju stavki iz primjera. Ona omogućuje ubacivanje i uklanjanje stavki. 
 * Također, i ona pruža mogućnost korištenja posjetitelja. Njena metoda Accept() redom poziva istu na svim stavkama koje drži 
 * te vraća zbroj. Izmijeniti posjetitelja za izračun cijene iznajmljivanja tako da cijena iznajmljivanja programske podrške 
 * bude jednaka cijeni prodaje.*/

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
