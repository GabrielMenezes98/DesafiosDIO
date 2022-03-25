using System;

namespace contadorIdades
{
    class Program
    {
        static void Main()
        {
            int resultado = 0;
            int idade = 0;

            Console.WriteLine("Insira a idade dos individuos:");
            for (int i=0; i <= 9; i++)
            {
                idade = int.Parse(Console.ReadLine());
                if (idade >= 18)
                {
                    resultado++;
                }
                else 
                {
                
                }


            }
            Console.WriteLine($"{resultado}  pessoas possuem mais de 18 anos.");    
                
             
            

        }
    }
}


