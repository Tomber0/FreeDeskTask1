using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDeskTask1.View
{
    class ConsolePrinter : Printer
    {
        public override void Print(string message)
        {
            Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} {message}");
        }
    }
}
