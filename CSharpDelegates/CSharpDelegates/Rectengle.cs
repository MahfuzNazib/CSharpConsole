using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    public class Rectengle
    {
        public void RectengleAre(double height, double width)
        {
            Console.WriteLine("Area is : " + height * width);
        }

        public void PairRectengle(double feet, double inch)
        {
            Console.WriteLine("Pair is : ", 2*(feet + 110) - inch);
        }
    }
}
