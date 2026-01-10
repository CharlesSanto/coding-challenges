using System; 

class URI {

    static void Main(string[] args) { 

        var values = Console.ReadLine().Split(' ');
        double a = double.Parse(values[0]);
        double b = double.Parse(values[1]);
        double c = double.Parse(values[2]);
        
        double pi = 3.14159;
        
        Console.WriteLine($"TRIANGULO: {((a * c) / 2):F3}");
        Console.WriteLine($"CIRCULO: {(pi * c * c):F3}");
        Console.WriteLine($"TRAPEZIO: {(((a + b) * c) / 2):F3}");
        Console.WriteLine($"QUADRADO: {(b * b):F3}");
        Console.WriteLine($"RETANGULO: {(a * b):F3}");

    }

}