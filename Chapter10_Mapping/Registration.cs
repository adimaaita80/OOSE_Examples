using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_Mapping
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public DateTime RegistrationDate { get; set; }

        public int MidtermExamMark { get; set; }
        public int FinalExamMark { get; set; }
        public int AssignmentMark { get; set; }

        public UniversityStudent UniversityStudent { get; set; }
        public UniversityCourse UniversityCourse { get; set; }
    }
}
