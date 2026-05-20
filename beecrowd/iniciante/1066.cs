using System; 

class URI {

    static void Main(string[] args) { 

        int pares = 0, impares = 0, positivos = 0, negativos = 0;

        for (int i = 0; i < 5; i++) {

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) pares++;
            if (n % 2 != 0) impares++;
            if (n > 0) positivos++;
            if (n < 0) negativos++;
        }

        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impares} valor(es) impar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");

    }

} 