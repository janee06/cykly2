using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cykly2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //průměr sudých čísel
            Console.WriteLine("Kolik chcete zadat čísel??");
            int cisla = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Zadejte čísla");
            int pocet_cisel = 0;
            int sude = 0;
            for (int i = 0; i < cisla; i++)
            {
                int b = Convert.ToInt16(Console.ReadLine());
                if (b % 2 == 0)
                {
                    sude += b;
                    pocet_cisel++;
                }

            }
            Console.WriteLine("Průměr sudých čisel je " + sude / pocet_cisel);

            Console.ReadKey();
        }
    }
}
