using System.Diagnostics;

namespace OtherCodeWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AllVariableWithType();
            TypeConversion();


            /*
             * If we used Const that means this value is not re-initialize again the saim scope. But we can again define same variable with 
             * another values in different scope;
             */
            const double pi = 3.1416;
            Console.WriteLine("PI Value is : " + pi);
        }

        public static void AllVariableWithType()
        {
            int serialNo = 10;
            double cgpa = 3.64;
            float quantity = 3;
            char ch = 'N';
            Console.WriteLine("The Variables are : {0}, {1}, {2}, {3}", serialNo, cgpa, quantity, ch);
        }

        public static void TypeConversion()
        {
            //ToStringConversion();
            //ImplicitTypeConversion();
            ExplicitTypeConversion();
        }

        public static void ToStringConversion()
        {
            // Integer, Double, Float, Bool, Short  to String
            int number = 25;
            double cgpa = 3.65;
            float qnty = 36.225f;
            bool IAmGood = true;
            short bb = 25;

            Console.WriteLine(number + " is : " + number.GetType() + ". Now its type is : " + number.ToString().GetType() + " & value is : " + number.ToString());
            Console.WriteLine(cgpa + " is : " + cgpa.GetType() + ". Now its type is : " + cgpa.ToString().GetType() + " & value is : " + cgpa.ToString());
            Console.WriteLine(qnty + " is : " + qnty.GetType() + ". Now its type is : " + qnty.ToString().GetType() + " & value is : " + qnty.ToString());
            Console.WriteLine(IAmGood + " is : " + IAmGood.GetType() + ". Now its type is : " + IAmGood.ToString().GetType() + " & value is : " + IAmGood.ToString());
            Console.WriteLine(bb + " is : " + bb.GetType() + ". Now its type is : " + bb.ToString().GetType() + " & value is : " + bb.ToString());
        }

        public static void ImplicitTypeConversion()
        {
            /*
             * In C#, Implicite Type Casting is Automatically. Basically smaller type like (int) can autometically converted larger type (double).
             */

            int num1 = 100;

            // Before Conversion
            Console.WriteLine("Before Conversion");
            Console.WriteLine("Variable Type : " + num1.GetType());
            Console.WriteLine("Variable Value : " + num1);

            //After Conversion
            double numDouble = num1;
            Console.WriteLine("After Conversion");
            Console.WriteLine("Variable Type : " + numDouble.GetType());
            Console.WriteLine("Variable Value : " + numDouble);
        }

        public static void ExplicitTypeConversion()
        {
            /*
             * In C#, we Explicitly Convert one type to another type;
             */

            double num1 = 100.002;
            // Before Conversion
            Console.WriteLine("Before Conversion");
            Console.WriteLine("Variable Type : " + num1.GetType());
            Console.WriteLine("Variable Value : " + num1);

            //After Conversion
            int numInt = (int)num1;
            Console.WriteLine("After Conversion");
            Console.WriteLine("Variable Type : " + numInt.GetType());
            Console.WriteLine("Variable Value : " + numInt);


            /*
             * Here we take a float type number as cgpa; Then explicitly convert into integer type. After that again this converted integert to string.
             */
            float cgpa = 3.64f;
            int roundedCGPA = (int)cgpa;

            string cgpaStatement = roundedCGPA.ToString();
            if(cgpaStatement == "3")
            {
                Console.WriteLine("Pass");

                double pi = 3.2562;
                Console.WriteLine("Here Pi Value is : " + pi);
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }


    }
}