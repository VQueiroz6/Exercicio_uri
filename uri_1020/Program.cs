using System;

namespace uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, quociente, resto;
            int ano = 365;
            int mes = 30;

            idade = int.Parse(Console.ReadLine());

            quociente = idade / ano;
            Console.WriteLine(quociente + "ano(s)");
            resto = idade % ano;

            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto = resto % mes;

            Console.WriteLine(resto + "dia(s)");
        }
    }
}
