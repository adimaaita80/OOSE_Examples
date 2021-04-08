using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainingActivityDiagrams
{
    public enum IncidentPriority
    {
        low,
        high_fire,
        high_no_fire
    }

    public class Incident
    {
        public int IncidentId { get; set; }
        public string IncidentDesc { get; set; }
        public IncidentPriority IncidentPriority { get; set; }
    }
}
