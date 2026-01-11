using System;

class URI
{
    static void Main(string[] args)
    {
        int[] cedulas = {100, 50, 20, 10, 5, 2, 1};
        int valor = int.Parse(Console.ReadLine());
        
        Console.WriteLine(valor);
        
        foreach(var c in cedulas)
        {
            int quantidade = valor / c;
            Console.WriteLine($"{quantidade} nota(s) de R$ {c},00");
            
            valor = valor % c;
        }
    }
}
