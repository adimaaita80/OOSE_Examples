using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_Mapping
{
    public class UniversityStudent
    {
        public int UniversityStudentId { get; set; }
        public string UniversityStudentName { get; set; }
        public List<UniversityCourse> UniversityCourses { get; set; }
        public List<Registration> Registrations { get; set; }

    }
}
