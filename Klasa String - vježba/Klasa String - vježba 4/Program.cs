using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_String___vježba_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            string[] rijeci = recenica.Split();
            Console.WriteLine(rijeci.First() + " " + rijeci.Last());
            Console.ReadKey();
        }
    }
}
