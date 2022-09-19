using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double CSMD = X / Y;

        //--cw--//
        Console.WriteLine(CSMD.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
    }
}
