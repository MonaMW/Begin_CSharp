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
            string trimmed_entry = entry.Trim(' ', 'a');
            //string trimmed_entry = entry.Replace("a", "");

            Console.WriteLine("Old String " + entry + ":");
            Console.WriteLine("New String " + trimmed_entry + ":");
            
            Console.ReadLine();
        }
    }
}
