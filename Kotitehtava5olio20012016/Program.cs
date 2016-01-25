using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava5olio20012016
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Radio testi1 = new Radio();
            testi1.OnOff = true;
            testi1.Frequency = 2000.0;
            testi1.Volume = 1;
            // display car data
            testi1.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            testi1.Change();
            // display car data again, notice changed speed value!
            testi1.PrintData();
            testi1.Change();
            Console.ReadLine();
            testi1.PrintData();
            Console.ReadLine();
            testi1.Change();
            testi1.PrintData();
            Console.ReadLine();
            testi1.Change();
            testi1.PrintData();
            Console.ReadLine();
            testi1.Change();
            testi1.PrintData();
            Console.ReadLine();
            testi1.Change();
        }
    }
}
