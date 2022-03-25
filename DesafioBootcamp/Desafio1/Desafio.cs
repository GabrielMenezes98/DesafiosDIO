using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema.
class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            if (Y == 0) {
              Console.WriteLine("Divisão Impossível");
                

            } else {
              Console.WriteLine($"{(X/Y):F1}");
                
            }
        }
    }
}


