using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_String___vježba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brojevi;

            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojeni s razmakom: ");
            brojevi = Console.ReadLine();

            int x;
            double y;

            string[] broj = brojevi.Split(' ');
            x = Convert.ToInt32(broj[0]);
            y = Convert.ToDouble(broj[1]);

            Console.WriteLine("Prvi broj je " + x + " i drugi je " + y);

            Console.ReadKey();
        }
    }
}
