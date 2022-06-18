using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface_app
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nLaserjet display dimesion : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("Laserjet printer printing....");
        }
    }
}
