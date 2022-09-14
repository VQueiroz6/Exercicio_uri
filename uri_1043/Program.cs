using System;
using System.Globalization;
namespace uri_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            double A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (A < B + C && A > Math.Abs(B - C))
            {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double area = (A + B) / 2.0 * C;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
