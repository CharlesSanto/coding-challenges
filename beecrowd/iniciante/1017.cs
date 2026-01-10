using System; 

class URI {

    static void Main(string[] args) { 

        double hours = double.Parse(Console.ReadLine());
        double velocidade = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"{((velocidade / 12) * hours):F3}");

    }
}