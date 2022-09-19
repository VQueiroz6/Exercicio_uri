using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split();

        int A = int.Parse(valores[0], CultureInfo.InvariantCulture);
        int B = int.Parse(valores[1], CultureInfo.InvariantCulture);
        int C = int.Parse(valores[2], CultureInfo.InvariantCulture);

        //Formulas

        double MAB = (A + B + Math.Abs(A - B)) / 2;
        double MABC = (MAB + C + Math.Abs(MAB - C)) / 2;

        Console.WriteLine(+MABC + " eh o maior");
    }
}
