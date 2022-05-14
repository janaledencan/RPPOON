using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

/*3. zad Testirati proxy-ije iz primjera 2.2 i 2.3. Za potrebe ispisa podataka napisati klasu DataConsolePrinter koja ima
odgovarajuću metodu za ispis. Također, za potrebe testiranja može se koristiti primjer CSV datoteke dan na
kraju ovog poglavlja.*/

namespace Proxy
{
    class DataConsolePrinter
    {

        public void PrintingData(IDataset dataSet)
        {
            ReadOnlyCollection<List<string>> proxyData = dataSet.GetData();

            foreach (List<string> information in proxyData)
            {
                foreach (string data in information)
                {
                    Console.Write(data + " ");
                }

                Console.WriteLine();
            }   
                
        }
    }
}
