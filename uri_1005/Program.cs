using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double prova1 = A * 3.5;
        double prova2 = B * 7.5;
        double media = (prova1 + prova2) / 11;

        Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
    }
}
