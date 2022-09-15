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
            Console.WriteLine("Gib mir ein Wort!");
            string entry = Console.ReadLine();
            string trimmed_entry = entry.Substring(3, 4);

            Console.WriteLine("Old entry " + entry + ":");
            Console.WriteLine("New entry " + trimmed_entry + ":");
            
            Console.ReadLine();
        }
    }
}
