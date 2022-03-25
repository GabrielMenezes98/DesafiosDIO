using System;

namespace exercicio1
{
    class Program
    {
        static void Main()
        {
            int nota1, nota2, nota3, nota4, nota5, media;
            Console.WriteLine("Insira a nota 1:");
            nota1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Insira a nota 2:");
            nota2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a nota 3:");
            nota3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a nota 4:");
            nota4 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Insira a nota 5:");
            nota5 = int.Parse(Console.ReadLine());
            
            media = nota1+nota2+nota3+nota4+nota5;

            Console.WriteLine(media/5);

            
        }
    }   
        
}