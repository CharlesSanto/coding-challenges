using System;

class URI {

    static void Main(string[] args) { 

        double raio = double.Parse(Console.ReadLine());
        
        double pi = 3.14159;
        
        double result = (pi) * (raio * raio);

        Console.WriteLine($"A={result:F4}");

    }

}