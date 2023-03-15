namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInput();
        }

        static void UserInput()
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}