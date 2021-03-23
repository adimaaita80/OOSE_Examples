using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermarket supermarket1 = new Supermarket();
            Supermarket supermarket2 = new Supermarket();

            supermarket1.SupermarketId = 1;
            supermarket1.SupermarketName = "Family Supermarket";
            supermarket1.SupermarketAddress = "Amman-Jordan";

            Console.WriteLine(supermarket1.SupermarketInformation());


            supermarket2.SupermarketId = 2;
            supermarket2.SupermarketName = "Amman Supermarket";
            supermarket2.SupermarketAddress = "Amman-Jordan";

            Console.WriteLine(supermarket2.SupermarketInformation());
        }
    }
}
