using System;
using System.Collections.Generic;
using System.Text;

/*2.zad. Napisati klasu ShippingService koja ima metodu za računanje cijene dostave paketa. Cijena se računa na
temelju mase/težine paketa i jedinične cijene za masu. Jedinična cijena za masu je atribut navedene klase.*/

namespace Kompozit
{
    class ShippingService
    {
        private double unitPrice;

        public ShippingService(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public double CalculatePacketPrice(Box packet)
        {
            return packet.Weight * unitPrice;
            
        }
    }
}
