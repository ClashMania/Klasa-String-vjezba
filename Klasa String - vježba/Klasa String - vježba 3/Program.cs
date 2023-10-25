using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_String___vježba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica;

            Console.WriteLine("Unesite niz znakova: ");
            recenica = Console.ReadLine();

            string sVelika = recenica.ToUpper();
            string sMala = recenica.ToLower();
            string sPrvaTri = recenica.Substring(0, 3);
            string sZadnjihPet = recenica.Substring(recenica.Length - 5, 5);
            string s8_11 = recenica.Substring(8, 4);

            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);

            Console.ReadKey();
        }
    }
}
