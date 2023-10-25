using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_String___vježba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("Unesite znakove: ");
            s1 = Console.ReadLine();
            Console.WriteLine(s1.Replace(" ", "_"));

            Console.ReadKey();
        }
    }
}
