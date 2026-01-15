using System;

class URI
{
    static void Main(string[] args)
    {
        var valores = Console.ReadLine().Split(' ');
        double[] lados = {
            double.Parse(valores[0]),
            double.Parse(valores[1]),
            double.Parse(valores[2])
        };

        Array.Sort(lados);
        Array.Reverse(lados);

        double a = lados[0];
        double b = lados[1];
        double c = lados[2];

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (a*a == (b*b) + (c*c))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a*a > b*b + c*c)
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else
                Console.WriteLine("TRIANGULO ACUTANGULO");

            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if (a == b || b == c || a == c)
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
