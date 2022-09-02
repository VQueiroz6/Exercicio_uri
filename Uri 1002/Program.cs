using System;
using System.Globalization;

namespace Uri_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = P * (raio * raio);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
