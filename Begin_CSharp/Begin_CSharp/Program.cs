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
            Console.WriteLine("Wie heißt du?");
            string userName = Console.ReadLine();
            //string userName = "Mona";
            Console.WriteLine("Hello " + userName);
            Console.ReadLine();
        }
    }
}
