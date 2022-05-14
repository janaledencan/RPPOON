using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = User.GenerateUser("Jane");

            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("D:/Faks/4.semestar/RPPOON/LV/LV5/Proxy/bin/Debug/netcoreapp3.1/sensitiveData.csv");
            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(user);

            DataConsolePrinter dataConsolePrinter = new DataConsolePrinter();

            dataConsolePrinter.PrintingData(virtualProxy);
            Console.WriteLine("Protection proxy:\n");
            dataConsolePrinter.PrintingData(protectionProxy);
        }
    
    }
}
