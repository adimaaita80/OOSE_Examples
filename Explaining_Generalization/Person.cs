using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explaining_Generalization
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Information()
        {
            return $"Id: {Id} \n Name: {Name} \n DOB: {DateOfBirth.ToString()}";
        }
    }
}
