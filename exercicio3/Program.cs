using System;

namespace exercicio3
{
    class Program
    {
        static void Main()
        {
            int a, teste;
            Console.WriteLine("Insira o valor desejado:");
            a = int.Parse(Console.ReadLine());
            teste = a % 2;

                if (teste != 0)
                {
                Console.WriteLine("O número é ímpar");
                }
                else
                {
                Console.WriteLine("O número é par");
                }

        }
    }
}


