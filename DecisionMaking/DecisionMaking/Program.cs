namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserMarkInput();
        }

        public static void UserMarkInput()
        {
            try
            {
                Console.WriteLine("Please Enter Your Marks : ");
                string inputMark = Console.ReadLine();
                double marks = Convert.ToDouble(inputMark);

                FindYourResult(marks);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReRunOrExit();
            }
        }

        public static void FindYourResult(double marks)
        {
            if(marks >= 88.88)
            {
                Console.WriteLine("Passed with Excellent Badge");
            }
            else if(marks >= 66.66)
            {
                Console.WriteLine("Passed with Good Badge");
            }
            else if(marks >= 33.33)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Sorry. You Failed");
            }

            ReRunOrExit();
        }

        public static void ReRunOrExit()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Again Calculation");
            Console.WriteLine("2. Exit Program");

            string userInput = Console.ReadLine();
            int takeDecision = Convert.ToInt32(userInput);

            if(takeDecision == 1)
            {
                UserMarkInput();
            }
            else if(takeDecision == 2)
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Sorry. No Option Found");
                ReRunOrExit();
            }
        }
    }
}