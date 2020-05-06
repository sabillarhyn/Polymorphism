using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace printer
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laser Jet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("Laser Jet printer printing ...");
        }
    }
}
