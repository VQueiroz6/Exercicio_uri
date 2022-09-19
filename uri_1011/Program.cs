using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double Raio3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double π = 3.14159;

        //--Formula--//
        double V = 4 / 3.0 * π * (Raio3 * Raio3 * Raio3);

        //--No Console--//
        Console.WriteLine("VOLUME = " + V.ToString("F3", CultureInfo.InvariantCulture));

    }
}
