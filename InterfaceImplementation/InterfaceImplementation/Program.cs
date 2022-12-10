namespace InterfaceImplementation
{
    internal class Program
    {
        public interface IAreaCalculation
        {
            void AreaResult();
            void GetShapeSize();
        }

        public interface ITexCalculation
        {
            void AreaResult();
        }

        public class Rectengle : IAreaCalculation, ITexCalculation
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