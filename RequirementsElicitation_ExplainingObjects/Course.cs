using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsElicitation_ExplainingObjects
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

        public Course()
        {
            Students = new List<Student>();
        }
    }
}
