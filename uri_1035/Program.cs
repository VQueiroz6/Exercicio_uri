using System;

namespace uri_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] leitura = Console.ReadLine().Split('  ');

            int A = int.Parse(leitura[0]);
            int B = int.Parse(leitura[1]);
            int C = int.Parse(leitura[2]);
            int D = int.Parse(leitura[3]);

            if(B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
