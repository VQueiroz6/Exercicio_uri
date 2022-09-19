using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




        double prova1 = NotaA * 2;
        double prova2 = NotaB * 3;
        double prova3 = NotaC * 5;
        double media = (prova1 + prova2 + prova3) / 10;



        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
    }
}
