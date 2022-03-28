using System;

class Classe {
    static void Main() {
        string[] line = Console.ReadLine().Split(" ");
        
        double H = double.Parse(line[0]);
        double P = double.Parse(line[1]);
        double MEDIA = H / P;
        Console.WriteLine(Math.Round(MEDIA, 2).ToString("N2"));   
    }   
}