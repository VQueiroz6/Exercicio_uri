using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split();

        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
        double pi = 3.14159;

        //Formula triângulo retângulo
        double atr = (a * c) / 2;
        //Formula círculo retângulo
        double cir = pi * (c * c);
        //Formula trapézio
        double trap = ((a + b) * c) / 2;
        //Formula quadrado
        double qua = b * b;
        //Formula retângulo
        double ret = a * b;

        Console.WriteLine("TRIANGULO: " + atr.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trap.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + qua.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));
    }
}
