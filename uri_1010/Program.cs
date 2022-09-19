using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string[] Prod1 = Console.ReadLine().Split();
        string[] Prod2 = Console.ReadLine().Split();

        int codigo1 = int.Parse(Prod1[0]);
        int prodname1 = int.Parse(Prod1[1]);
        double valor1 = double.Parse(Prod1[2], CultureInfo.InvariantCulture);

        int codigo2 = int.Parse(Prod2[0]);
        int prodname2 = int.Parse(Prod2[1]);
        double valor2 = double.Parse(Prod2[2], CultureInfo.InvariantCulture);

        double Vvalor1 = prodname1 * valor1;
        double Vvalor2 = prodname2 * valor2;
        double Vtotal = Vvalor1 + Vvalor2;

        Console.WriteLine("VALOR A PAGAR: R$ " + Vtotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}
