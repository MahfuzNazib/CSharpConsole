namespace CSharpCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCollection();
            //AnotherListCollections();
            //ListWithClass();
        }

        public static void SimpleCollection()
        {
            var salmons = new List<string> { "ABC", "abc", "aaa"};
            salmons.Add("Nazib");
            salmons.Add("Mahfuz");
            salmons.Add("Ali Hasan");
            salmons.Add("Sufian");

            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon);
            }

            salmons.Remove("abc");
            Console.WriteLine("----");
            salmons.Insert(2, "New Inserted");
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon);
            }

        }

        public static void AnotherListCollections()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Before Removing, the List is");
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }

            foreach(int number in numbers.ToList())
            {
                if(number %2 == 1)
                {
                    numbers.Remove(number);
                }
            }

            Console.WriteLine("After Removing, the List is");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void ListWithClass()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() {Name = "Tadpole", MegaLightYear = 450},
                new Galaxy() {Name = "Pinwheel", MegaLightYear = 25},
                new Galaxy() {Name = "Milk Way", MegaLightYear=10}
            };

            foreach(var theGalaxy in theGalaxies) 
            {
                Console.WriteLine($"Galaxy Name : {theGalaxy.Name} and MegaLightYear : {theGalaxy.MegaLightYear}");
            }
        }

        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYear { get; set; }
        }
    }
}