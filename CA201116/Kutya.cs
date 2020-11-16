using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201116
{
    class Kutya : Allat
    {
        override public void HangotAdKi()
        {
            Console.ForegroundColor = Szin;
            Console.WriteLine($"{Nev} modja: Vau-vau!");
            Console.ResetColor();
        }
    }
}
