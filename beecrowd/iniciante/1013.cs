using System; 

class URI {

    static void Main(string[] args) { 

        var values = Console.ReadLine().Split(' ');
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);
        
        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorAC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
        
        Console.WriteLine($"{maiorAC} eh o maior");
        
    }

}