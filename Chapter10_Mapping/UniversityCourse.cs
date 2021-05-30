using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_Mapping
{
    public class UniversityCourse
    {
        public int UniversityCourseId { get; set; }
        public string UniversityCourseName { get; set; }
        public List<UniversityStudent> UniversityStudents { get; set; }
        public List<Registration> Registrations { get; set; }
    }
}
