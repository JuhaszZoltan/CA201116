using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201116
{
    class Allat
    {
        public String Nev { get; set; }
        public ConsoleColor Szin { get; set; }

        virtual public void HangotAdKi()
        {
            Console.ForegroundColor = Szin;
            Console.WriteLine($"{Nev} modja: Valami-Valami!");
            Console.ResetColor();
        }
    }
}
