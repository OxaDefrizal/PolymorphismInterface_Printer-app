using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface_app
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nEpson display dimesion : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
