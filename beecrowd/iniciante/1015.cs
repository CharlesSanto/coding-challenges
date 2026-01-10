using System; 

class URI {

    static void Main(string[] args) { 

        var value1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(value1[0]);
        double y1 = double.Parse(value1[1]);
        
        var value2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(value2[0]);
        double y2 = double.Parse(value2[1]);
        
        double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        
        Console.WriteLine($"{result:F4}");
    }

}