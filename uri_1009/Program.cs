using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string NOME = Console.ReadLine();

        //--Salario Fixo e Número total de vendads--//
        double Sf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double NTV = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //--Formula--//
        double Comissao = NTV * 0.15;
        double BONUS = Sf + Comissao;

        //--Imprimir no Console--//
        Console.WriteLine("TOTAL = R$ " + BONUS.ToString("F2", CultureInfo.InvariantCulture));
    }
}
