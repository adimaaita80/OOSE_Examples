using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityCourse course1 = new UniversityCourse();
            UniversityCourse course2 = new UniversityCourse();

            UniversityStudent student1 = new UniversityStudent();
            student1.UniversityStudentId = 1;
            student1.UniversityStudentName = "Majd";


            Registration registration1 = new Registration();
            registration1.RegistrationId = 1;
            registration1.RegistrationDate = DateTime.Now;
            registration1.UniversityStudent = student1;
            registration1.UniversityCourse = course1;
            registration1.MidtermExamMark = 32;
            registration1.FinalExamMark = 45;
            registration1.AssignmentMark = 15;

            student1.Registrations.Add(registration1);
            course1.Registrations.Add(registration1);

            Registration registration2 = new Registration();
            registration1.RegistrationId = 2;
            registration1.RegistrationDate = DateTime.Now;
            registration1.UniversityStudent = student1;
            registration1.UniversityCourse = course2;
            registration1.MidtermExamMark = 30;
            registration1.FinalExamMark = 46;
            registration1.AssignmentMark = 12;

            student1.Registrations.Add(registration2);
            course2.Registrations.Add(registration2);


        }
    }
}
