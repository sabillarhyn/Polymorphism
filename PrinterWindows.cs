using System;
using System.Collections.Generic;
using System.Text;

namespace printer
{
    class PrinterWindows
    {
        public string Merk { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("\n");
        }
        public virtual void Print()
        {
            Console.WriteLine("\n");
        }
    }
}
