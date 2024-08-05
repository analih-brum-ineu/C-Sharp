using System;
using System.Globalization;

namespace PrimeiroExercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, preçom2, area, preçof;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preçom2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preçof = area * preçom2;

            Console.WriteLine("Área: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço final: " + preçof.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
