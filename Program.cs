using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism menggunakan Interface\n");
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows convert; 

            if (nomorPrinter == 1)
                convert = new Epson();
            else if (nomorPrinter == 2)
                convert = new Canon();
            else
                convert = new LaserJet();

            convert.Show();
            convert.Print();

            Console.ReadKey();
        }
    }
}
