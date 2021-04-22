using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsElicitation_ExplainingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 1;
            student.StudentName = "Adi Maaita";

            Student student1 = new Student();
            student1.StudentId = 2;
            student1.StudentName = "Ahmad Mohammad";

            Course course = new Course();
            course.CourseId = 1;
            course.CourseName = "Calculus 101";

            Registration registration = new Registration();

            registration.RegisterStudentInCourse(student, course);
            registration.RegisterStudentInCourse(student1, course);

            registration.WithdrawStudentFromCourse(student, course);

            Console.WriteLine(registration.RegisteredStudentsInCourse(course));
        }
    }
}
