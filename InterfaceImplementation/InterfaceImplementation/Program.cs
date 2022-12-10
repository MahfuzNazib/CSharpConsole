namespace InterfaceImplementation
{
    internal class Program
    {
        /*
         * AreaCalculation Interface. It has two method.
         * 1. AreaResult
         * 2. GetShapeSize
         */
        public interface IAreaCalculation
        {
            void AreaResult();
            void GetShapeSize();
        }
        
        /*
         * This is another Interface called TexCalculation
         * It has only one method Called AreaResult also.
         */
        public interface ITexCalculation
        {
            void AreaResult();
        }

        /*
         * New class called Rectengle. This class inherite one interfaces
         * which is IAreaCalculation. In that case Both two methods must be declare inside Rectengle class.
         */
        public class Rectengle : IAreaCalculation
        {
            public void AreaResult()
            {
                Console.WriteLine("Area of Rectengle is : 20");
            }

            public void GetShapeSize()
            {
                Console.WriteLine("The shpae of the size is : Rectengle");
            }
        }

        /*
         * Another new class called Circle. This class inherit two Interface class. 
         * 1. IAreaCalculation & 
         * 2. ITexCalculation.
         * 
         * Here one thing is noticable. Bothe Interface have a same name method called AreaResult()
         * Here we need explicite interface implementation.
         */
        public class Circle : IAreaCalculation, ITexCalculation
        {
            // Explicite Implementation. Called IAreaCalculation AreaResult Method
            void IAreaCalculation.AreaResult()
            {
                Console.WriteLine("Area of Circle is : 99.009");
            }

            // Explicite Implementation. Called ITexCalculation AreaResult Method
            void ITexCalculation.AreaResult()
            {
                Console.WriteLine("Area Result from TexCalculation");
            }

            // Just Called the method. Because its a unique method from IAreaCalculation Interface.
            public void GetShapeSize()
            {
                Console.WriteLine("The shape of the size is : Circle");
            }
        }

        static void Main(string[] args)
        {
            // Create a new Object of Rectengle Class & called classes methods.
            Rectengle rectengle = new Rectengle();
            rectengle.AreaResult();
            rectengle.GetShapeSize();

            /*
             * Create a new Object of Circle Class. But here we can't call circle.AreaResult() method like this.
             * Because we have two same method from different Interface Classes.
             * That's why we called it like below 
             */
            Circle circle = new Circle();
            
            IAreaCalculation iArea = new Circle();
            iArea.AreaResult();

            ITexCalculation iTex = new Circle();
            iTex.AreaResult();

            circle.GetShapeSize();
        }
    }
}