using System; 

class URI {

    static void Main(string[] args) { 

        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double totalSales = double.Parse(Console.ReadLine()) * 0.15;
        
        double result = salary + totalSales;
        
        Console.WriteLine($"TOTAL = R$ {result:F2}");

    }

}