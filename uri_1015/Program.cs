using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string[] ponto1 = Console.ReadLine().Split();
        string[] ponto2 = Console.ReadLine().Split();

        double x1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);
        double x2 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);

        double y1 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);

        double distancia = Math.Sqrt(Math.Pow(x1 - y1, 2.00) + Math.Pow(x2 - y2, 2.00));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

    }
}
