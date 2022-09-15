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
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 28)
                Console.WriteLine("Viel Spaß!");
            else if (age >= 18 && age < 28)
                Console.WriteLine("Bitte Auweis!");
            else
                Console.WriteLine("Du kommst hier nicht rein!");
            Console.ReadLine();
        }
    }
}
