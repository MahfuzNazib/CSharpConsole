using System.Reflection.Metadata;

namespace CSharpList
{
    public class Program : Student
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Initializing Empty List...");
            //List <Int32> numberList = new List<Int32>();
            ////Wait for 3 Second
            //Thread.Sleep(2000);
            //Console.WriteLine("Initiliazation Done");
            //NumberInput(numberList);
            //

            Console.WriteLine("Choose The Correct Option");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Student Object  2. Int32");
            int userOptionInput = Convert.ToInt32(Console.ReadLine());

            if(userOptionInput == 1)
            {
                Console.WriteLine("Initilizing Student Object");
                List<Student> student = new List<Student>();
                Thread.Sleep(3000);
                Console.WriteLine("Student List is Initialized");
                PrintStudentList(student);
            }
        }

        public static void PrintStudentList(List<Student> studentList)
        {
            foreach(Student student in studentList)
            {
                Console.WriteLine("Student List Contain");
                Console.WriteLine("Index[{0}] : {1}", studentList.IndexOf(student));
            }
        }

        public static void StudentListManage(List<Student> studentList)
        {
            Console.WriteLine("Choose Option");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Add Student; 2. Remove Student; 3. Print Student List");
            int userInputStudentManage = Convert.ToInt32(Console.ReadLine());

            if(userInputStudentManage == 1)
            {

            }
        }

        public static void NumberInput(List<Int32> numberList)
        {
            Console.WriteLine("-------");
            Console.WriteLine("1. Add into the List; 2. Remove from the List; 3.Exit Program");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if(inputNumber == 1)
            {
                AddToList(numberList);
            }
            else if(inputNumber == 2)
            {
                RemoveFromList(numberList);
            }
            else if(inputNumber == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong Input Number. Try Again");
                NumberInput(numberList);
            }
        }

        public static void AddToList(List<Int32> numberList)
        {
            Console.WriteLine("Add to List");
            int addNextNumber = Convert.ToInt32(Console.ReadLine());

            numberList.Add(addNextNumber);

            Console.WriteLine("1.Again Add? 2.Print List 3.Remove Item");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput == 1)
            {
                AddToList(numberList);
            }
            else if(userInput == 2)
            {
                PrintList(numberList);
            }
            else if(userInput == 3)
            {
                RemoveFromList(numberList);
            }
            else
            {
                Console.WriteLine("Wrong Input");
                NumberInput(numberList);
            }
        }

        public static void PrintList(List<Int32> numberList)
        {
            Console.WriteLine("Your List Contains");

            foreach(Int32 number in numberList)
            {
                Console.WriteLine("Index[{0}] : {1}", numberList.IndexOf(number), number);
            }

            //NumberInput(numberList);
        }

        public static void RemoveFromList(List<Int32> numberList)
        {
            PrintList(numberList);
            Console.WriteLine("Enter Index Number to Remove : ");
            int indexNo = Convert.ToInt32(Console.ReadLine());
            numberList.RemoveAt(indexNo);
            Console.WriteLine("Removing Item at {0}", indexNo);
            Thread.Sleep(2000);
            Console.WriteLine("Successfully Removed");

            PrintList(numberList);
        }

        
    }
}