using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz");
            double Boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (Boy * Boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız...");
                Console.ReadLine();

            }
            else if (bke >= 18 && bke < 25)
            {


                Console.WriteLine("Normalsiniz");
                Console.ReadLine();
            }
            else if (bke >= 25)
            {
                Console.WriteLine("Obezsiniz");
                Console.ReadLine();

            }

        }
    }
}
