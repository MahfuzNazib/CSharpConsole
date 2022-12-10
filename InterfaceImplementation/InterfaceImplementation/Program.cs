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
         * which is IAreaCalculation. In that case Both two methods must be declare inside Rectengle class
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


        public class Circle : IAreaCalculation, ITexCalculation
        {
            void IAreaCalculation.AreaResult()
            {
                Console.WriteLine("Area of Circle is : 99.009");
            }

            void ITexCalculation.AreaResult()
            {
                Console.WriteLine("Area Result from TexCalculation");
            }

            public void GetShapeSize()
            {
                Console.WriteLine("The shape of the size is : Circle");
            }
        }

        static void Main(string[] args)
        {
            Rectengle rectengle = new Rectengle();
            rectengle.AreaResult();
            rectengle.GetShapeSize();

            Circle circle = new Circle();
            
            IAreaCalculation iArea = new Circle();
            iArea.AreaResult();

            ITexCalculation iTex = new Circle();
            iTex.AreaResult();

            circle.GetShapeSize();
        }
    }
}