using System; 

class URI {

    static void Main(string[] args) { 

        double raio = double.Parse(Console.ReadLine());
        
        double pi = 3.14159;
        
        double result = (4/3.0) * pi * (raio * raio * raio);
        
        Console.WriteLine($"VOLUME = {result:F3}");
    }

}