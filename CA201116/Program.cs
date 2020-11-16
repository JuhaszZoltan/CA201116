using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201116
{
    class Program
    {
        static void Main()
        {
            var k1 = new Kutya() { Nev = "Bodri", Szin = ConsoleColor.DarkGreen, };

            var m1 = new Macska() { Nev = "Jack Sperrow", Szin = ConsoleColor.Red, };

            var allatok = new List<Allat>();

            k1.HangotAdKi();
            m1.HangotAdKi();

            Console.WriteLine("---------------------------");

            allatok.Add(k1);
            allatok.Add(m1);


            for (int i = 0; i < allatok.Count; i++)
            {
                allatok[i].HangotAdKi();
            }


            Allat a = new Allat() { Nev = "Teve", Szin = ConsoleColor.Yellow, };

            a.HangotAdKi();



            Console.ReadKey();
        }
    }
}
