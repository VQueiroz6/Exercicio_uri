using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        int Nf = int.Parse(Console.ReadLine());
        //--horas trabalhadas--//
        int Ht = int.Parse(Console.ReadLine());
        //--Recebe a Hora--//
        double RAH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //--Calculo--//
        double SALARIO = Ht * RAH;

        //--Console--//

        Console.WriteLine("NUMBER = " + Nf);
        Console.WriteLine("SALARY = U$ " + SALARIO.ToString("F2", CultureInfo.InvariantCulture));
    }
}
