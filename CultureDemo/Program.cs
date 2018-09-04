using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CultureInfo.CurrentCulture);

            Console.WriteLine("NumberDecimalSeparator: " + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            double temperatur;

            temperatur = Convert.ToDouble(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US") );

            Console.WriteLine("Temperatur: " + Convert.ToString(temperatur));
        }
    }
}
