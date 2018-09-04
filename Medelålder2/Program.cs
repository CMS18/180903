using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medelålder2
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int antal;

            Console.WriteLine("Beräkna medelålder");
            Console.Write("Antal personer: ");

            antal = int.Parse(Console.ReadLine());

            for (int i = 0; i < antal; i++)
            {
                Console.Write($"Ålder {i+1}? ");
                string text = Console.ReadLine();
                summa = summa + Convert.ToInt32(text);
            }
        
            double medelålder = (double)summa / antal;

            Console.WriteLine($"Medelålder {medelålder:0.00}");
        }
    }
}
