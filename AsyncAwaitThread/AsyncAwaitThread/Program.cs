namespace AsyncAwaitThread
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            LongProcess();
            ShortProcess();
        }

        public static async Task LongProcess()
        {
            Console.WriteLine("Long Process Start");
            Console.WriteLine("==Waiting 4 sec.==");
            await Task.Delay(4000);
            Console.WriteLine("Long Process End!!");
        }

        public static void ShortProcess()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Short Process Start");
            Console.WriteLine("No Waiting");
            Console.WriteLine("Short Process End");
        }
    }
}