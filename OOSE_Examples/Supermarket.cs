using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE_Examples
{
    public class Supermarket
    {
        // The state of a Supermarket object
        public int SupermarketId { get; set; }
        public string SupermarketName { get; set; }
        public string SupermarketOwnerName { get; set; }
        public string SupermarketAddress { get; set; }
        public string SupermarketPhone { get; set; }

        // The behaviour of a Supermarket object
        public string SupermarketInformation()
        {
            return $"Supermarket name: {SupermarketName} \n Supermarket address: {SupermarketAddress} \n Supermarket phone: {SupermarketPhone}";
        }
    }
}
