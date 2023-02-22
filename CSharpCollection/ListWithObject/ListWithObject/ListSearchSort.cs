using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithObject
{
    public class ListSearchSort : Student
    {
        public List<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>();

            students.Add( new Student() { StudentCode=1011, StudentName="Nazib Mahfuz", MajorCourse="Software Engineering", CGPA=3.65} );
            students.Add( new Student() { StudentCode=1012, StudentName="Ali Hasan", MajorCourse="MIS", CGPA=4.00} );

            foreach(Student student in students)
            {
                Console.WriteLine("Student Code : " + student.StudentCode);
                Console.WriteLine("Student Name : " + student.StudentName);
                Console.WriteLine("Major Course : " + student.MajorCourse);
                Console.WriteLine("Student CGPA : " + student.CGPA);

                Console.WriteLine("\n");
            }

            return students;
        }

        

    }
}
