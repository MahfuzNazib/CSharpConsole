namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartupCalculator();
        }

        public static void StartupCalculator()
        {
            Console.WriteLine("WELCOME TO CONSOLE CALCULATOR");
            Console.WriteLine("=============================");
            Console.WriteLine("Enter Number of Calculation : ");
            int numberOfCalculation = Convert.ToInt32(Console.ReadLine());

            NumberInputs(numberOfCalculation);
        }

        public static void NumberInputs(int numberOfInputs)
        {
            int[] numbers = new int[numberOfInputs];

            for(int i = 1; i <= numberOfInputs; i++)
            {
                Console.WriteLine("Enter Number : " + i);
                numbers[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            ArithmeticOparetion(numbers);
        }

        public static void ArithmeticOparetion(int[] numbers)
        {
            Console.WriteLine("CHOOSE OPERATOR\n");
            Console.WriteLine("1. PLUS(+)  2. MINUS(-)  3. MULTIPLICATION(*)");
            int operation = Convert.ToInt32(Console.ReadLine());

            if(operation == 1)
            {
                Summation(numbers);
            }
            else if(operation == 2)
            {
                MinusCalculation(numbers);
            }
            else if(operation == 3)
            {
                // MULTIPLICATION
            }
            else
            {
                Console.WriteLine("Invalid Operation Choose Number.");
                RunOrExit();
            }
        }

        public static void RunOrExit()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("1. Try Again ? ");
            Console.WriteLine("2. Exit Program");
            int takeDecision = Convert.ToInt32(Console.ReadLine());

            if(takeDecision == 1) 
            {
                StartupCalculator();
            }
            else if(takeDecision == 2)
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("INVALID OPTION");
                RunOrExit();
            }
        }

        public static void Summation(int[] numbers)
        {
            int result = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                result+= numbers[i];
            }
            Console.WriteLine("Result is : " + result);
            RunOrExit();
        }

        public static void MinusCalculation(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            Console.WriteLine("Result is : " + result);
            RunOrExit();
        }
    }
}