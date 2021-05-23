using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_Mapping
{
    public class Car
    {
        public string CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public LicensePlate LicensePlate { get; set; }
        public Owner Owner { get; set; } /* This is the 1 side of the 1 to Many relationship with Owner */

        public string GetCarInformation()
        {
            return "";
        }
    }
}
