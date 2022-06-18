using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface_app
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nCanon display dimesion : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}
