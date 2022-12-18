namespace StringReverseWithRecursion
{
    internal class Program
    {
        static int Main(string[] args)
        {
            string[] operations = { "X++", "++X", "--X", "X--" };
            int result = 0;

            for(int i = 0; i< operations.Length; i++)
            {
                if (operations[i].Contains("--X"))
                {
                    result -= 1;
                }
                else if (operations[i].Contains("X--"))
                {
                    result -= 1;
                }
                else if(operations[i].Contains("X++"))
                {
                    result += 1;
                }else
                {
                    result += 1;
                }
            }

            return result;
        }
    }
}