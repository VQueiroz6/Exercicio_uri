using System;

namespace Uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, n100, n50, n20, n10, n5, n2, n1, resto;

            N = int.Parse(Console.ReadLine());

            n100 = N / 100;
            resto = N % 100;
            
            
            n50 = N / 50;
            resto = N % 50;

            n20 = N / 20;
            resto = N % 20;
           
            n10 = N / 10;
            resto = N % 10;
            
            n5 = N / 5;
            resto = N % 5;
            
            n2 = N / 2;
            resto = N % 2;

            n1 = N / 1;
            resto = N % 1;

            Console.WriteLine(N);
            Console.WriteLine(n100 + "nota(s) de R$ 100,00"); 
            Console.WriteLine(n50 + "nota(s) de R$ 50,00");
            Console.WriteLine(n20 + "nota(s) de R$ 20,00");
            Console.WriteLine(n10 + "nota(s) de R$ 10,00");
            Console.WriteLine(n5 + "nota(s) de R$ 5,00");
            Console.WriteLine(n2 + "nota(s) de R$ 2,00");
            Console.WriteLine(n1 + "nota(s) de R$ 1,00");
        }
    }
}
