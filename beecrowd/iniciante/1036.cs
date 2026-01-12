using System;

class URI
{
    static void Main(string[] args)
    {
        var valores = Console.ReadLine().Split(' ');

        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);

        double delta = (b * b) - (4 * a * c);

        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double raiz = Math.Sqrt(delta);

            double r1 = (-b + raiz) / (2 * a);
            double r2 = (-b - raiz) / (2 * a);

            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");
        }
    }
}
