using System;
using System.Linq;

namespace CSLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryCSLinq();
            //TryAnother();
            ComplexLinqWithObj();
        }

        public static void TryCSLinq()
        {
            Console.WriteLine("C# LINQ");
            string[] words = { "Hello", "Nazib", "Mahfuz", "Wonderfuldcsdcsdcsdcsdcsdcsdcs" };

            // Get the words which length is less then 3;
            var shortWords = from word in words where word.Length >= 15 select word;
            if(shortWords.Any())
            {
                Console.WriteLine("Have");
            }
            else
            {
                Console.WriteLine("Don't Have");
            }

            foreach(var word in shortWords) 
            {
                Console.WriteLine(word);    
            }
        }

        public static void TryAnother()
        {
            List<int> numbers = new List<int>() { 1, 5, 9, 55, 11, 0, 59 };

            var orderedNumbers = from number in numbers orderby number where number >= 5 where number <= 45 select number;

            foreach(var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----");
            numbers.Add(34);

            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void ComplexLinqWithObj()
        {
            var Result = from result in Student.GetAllStudents() where result.TotalMarks > 180 select result;

            foreach(var result in Result)
            {
                Console.WriteLine($"Student Name : {result.Name}; Total Marks : {result.TotalMarks}");
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }
            public List<Subject> Subjects { get; set; }

            public static List<Student> GetAllStudents()
            {
                List<Student> listsStudent = new List<Student>()
                {
                    new Student
                    {
                        Id = 1,
                        Name= "Test",
                        TotalMarks = 125,
                        Subjects = new List<Subject>()
                        {
                            new Subject()
                            {
                                SubjectName= "TOC",
                                Marks = 100
                            },
                            new Subject()
                            {
                                SubjectName = "EEE1",
                                Marks = 25
                            }
                        }
                    },

                    new Student
                    {
                        Id = 2,
                        Name= "Hasan",
                        TotalMarks= 250,
                        Subjects = new List<Subject>()
                        {
                            new Subject()
                            {
                                SubjectName = "TOC",
                                Marks = 150
                            },
                            new Subject()
                            {
                                SubjectName = "TOC",
                                Marks = 100
                            }
                        }
                    }
                };

                return listsStudent;
            }
        }

        public class Subject
        {
            public string SubjectName { get; set; }
            public int Marks { get; set; }
        }

    }
}