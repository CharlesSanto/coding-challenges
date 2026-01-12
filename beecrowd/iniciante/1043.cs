using System; 

class URI {

    static void Main(string[] args) { 

        var valores =  Console.ReadLine().Split(' ');
        
        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);
        
        if (a < b + c && b < a + c && c < a + b)
        {
            double perimentro = a + b + c;
            Console.WriteLine($"Perimetro = {perimentro:F1}");
        } else 
        {
            double area = ((a + b) * c) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }

    }

}