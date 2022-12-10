namespace AbstactClassImplementation
{
    internal class Program
    {
        /*
         * Define an Abstract Class called Shape. In this Shape abstract class there has a abstract method called Draw.
         * This Draw() method have no body. 
         */
        public abstract class Shape
        {
            public abstract void Draw();
        }

        /*
         * A New class called Rectengle which inherite Shape abstract class.
         */
        public class Rectengle : Shape
        {
            /* This Draw class must be overrided. Because its a abstract method. 
             * Abstract method can't use without overriding technique.
            */
            public override void Draw()
            {
                Console.WriteLine("Draw from Rectengle Class");
            }
        }

        public class Circle : Rectengle, CalculateSize
        {
            public int SumTwo()
            {
                return 10 + 25;
            }
            
            public override void SizeOfBox()
            {

            }
        }
        static void Main(string[] args)
        {
            Rectengle rectengle = new Rectengle();
            rectengle.Draw();

            Circle circle = new Circle();
            Console.WriteLine(circle.SumTwo());
            circle.Draw();
        }
    }
}