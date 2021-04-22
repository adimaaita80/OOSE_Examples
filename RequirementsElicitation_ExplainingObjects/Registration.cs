using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsElicitation_ExplainingObjects
{
    public class Registration
    {
        public void RegisterStudentInCourse(Student student, Course course)
        {
            student.Courses.Add(course);
            course.Students.Add(student);
        }

        public void WithdrawStudentFromCourse(Student student, Course course)
        {
            student.Courses.Remove(course);
            course.Students.Remove(student);
        }

        public string RegisteredStudentsInCourse(Course course)
        {
            string result = "";

            foreach(Student student in course.Students)
            {
                result += student.StudentName + "\n";
            }

            return result;
        }
    }
}
