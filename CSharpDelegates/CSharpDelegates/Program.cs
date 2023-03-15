namespace CSharpDelegates
{
    //Define Delegates
    public delegate void PerformCalculation(double param1, double param2);
    public class Program
    {
        static void Main(string[] args)
        {
            Rectengle rectengle= new Rectengle();
            rectengle.RectengleAre(1.25, 3.52);
            rectengle.PairRectengle(25.24, 8.3);
        }
    }
}