using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_Mapping
{
    public class Owner
    {
        public string SocialSecurityNumber { get; set; }
        public string FullName { get; set; }
        public List<Car> Cars { get; set; } /* This is the many side of the 1 to many relationship with Car */
    }
}
