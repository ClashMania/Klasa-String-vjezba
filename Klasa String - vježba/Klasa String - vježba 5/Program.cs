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

            x = Convert.ToInt32(brojevi.Split(' ')[0]);
            y = Convert.ToDouble(brojevi.Split(' ')[1]);

            Console.WriteLine("Prvi broj je " + x + " i drugi je " + y);

            Console.ReadKey();
        }
    }
}
