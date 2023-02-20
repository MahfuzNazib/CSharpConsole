using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithObject
{
    public class ListSearchSort
    {
        public void StringList()
        {
            List<string> studentsName = new List<string>();
            studentsName.Add("Nazib");
            studentsName.Add("Mahfuz");
            studentsName.Add("Software Engineer");
            studentsName.Add("hSenid");
            studentsName.Add("Business Solutions");

            PrintList(studentsName);

            // Check a specific Item is exists on List or not
            Console.WriteLine(studentsName.Contains("Nazib Mahfuz"));

            studentsName.RemoveRange(0, 2);

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach(string car in cars)
            {
                studentsName.Add(car);
            }

            Console.WriteLine("Add More String on List");
            string[] userInputs = { };
            string userInput = Convert.ToString(Console.ReadLine());
            PrintList(studentsName);
        }

        public void PrintList(List<string> studentsName)
        {
            foreach(string name in studentsName) 
            {
                Console.WriteLine(name);
            }
        }

    }
}
