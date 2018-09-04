using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medelålder1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int antal = 0;

            Console.WriteLine("Beräkna medelålder");
            Console.WriteLine("Avsluta inmatning med enter");

            do
            {
                Console.Write("Ålder? ");
                string text = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(text)) break;

                summa = summa + Convert.ToInt32(text);
                antal = antal + 1;

            } while (true);

            double medelålder = (double)summa / antal;

            Console.WriteLine($"Medelålder {medelålder:0.00}");
        }
    }
}
