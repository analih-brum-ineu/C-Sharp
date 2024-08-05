using System;
using System.Globalization;

namespace URI1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, n, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n = 3.14159;

            area = n * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
