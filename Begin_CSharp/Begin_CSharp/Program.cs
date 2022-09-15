using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie groß bist du (in Meter)?");
            double height = Convert.ToDouble(Console.ReadLine());
            int multiplicator = 3;

            Console.WriteLine("Du bist " + height * multiplicator + "m groß.");
            Console.ReadLine();
        }
    }
}
