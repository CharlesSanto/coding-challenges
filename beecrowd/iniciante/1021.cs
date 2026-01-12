using System;

class URI
{
    static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine());

        int totalCentavos = (int)Math.Round(valor * 100);

        int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] moedas = { 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");
        foreach (int nota in notas)
        {
            int quantidade = totalCentavos / nota;
            Console.WriteLine($"{quantidade} nota(s) de R$ {(nota / 100.0):F2}");
            totalCentavos %= nota;
        }

        Console.WriteLine("MOEDAS:");
        foreach (int moeda in moedas)
        {
            int quantidade = totalCentavos / moeda;
            Console.WriteLine($"{quantidade} moeda(s) de R$ {(moeda / 100.0):F2}");
            totalCentavos %= moeda;
        }
    }
}
