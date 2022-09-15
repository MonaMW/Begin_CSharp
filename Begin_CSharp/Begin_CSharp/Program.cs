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
            string entry = "Das ist ein Text mit Wörtern";
            string[] entries = entry.Split(' ');
            foreach (string wort in entries)
            {
                Console.WriteLine(wort);
            }
            
            Console.ReadLine();
        }
    }
}
