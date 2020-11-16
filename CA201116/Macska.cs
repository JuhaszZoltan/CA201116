using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201116
{
    class Macska : Allat
    {
        override public void HangotAdKi()
        {
            Console.ForegroundColor = Szin;
            Console.WriteLine($"{Nev} modja: Miaú-miaú!");
            Console.ResetColor();
        }
    }
}
