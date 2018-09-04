using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RäknaVokalerOchKonsonanter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ord;
            int vokaler = 0;
            int konsonanter = 0;

            Console.Write("Skriv in ett ord: ");
            ord = Console.ReadLine().ToUpper();

            foreach (char bokstav in ord)
            {
                if (ärVokal(bokstav))
                {
                    vokaler = vokaler + 1;
                }
                else
                {
                    konsonanter = konsonanter + 1;
                }
            }

            Console.WriteLine($"Antal bokstäver: {vokaler+konsonanter}");
            Console.WriteLine($"Antal vokaler: {vokaler}");
            Console.WriteLine($"Antal konsonanter: {konsonanter}");

        }

        private static bool ärVokal(char bokstav)
        {
            return "AOUÅEIYÄÖ".Contains(bokstav);
        }
    }
}
