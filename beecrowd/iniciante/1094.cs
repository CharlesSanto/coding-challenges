using System; 

class URI {

    static void Main(string[] args) { 

        int quantidade = int.Parse(Console.ReadLine());

        int coelhos = 0, ratos = 0, sapos = 0; 
        int total = 0;

        for (int i = 0; i < quantidade; i++)
        {
            var entrada = Console.ReadLine().Split(' ');

            int quantidadeAnimais = int.Parse(entrada[0]);
            string tipoAnimal = entrada[1];

            total += quantidadeAnimais;

            if (tipoAnimal == "C") coelhos += quantidadeAnimais;
            else if (tipoAnimal == "R") ratos += quantidadeAnimais;
            else if (tipoAnimal == "S") sapos += quantidadeAnimais;

        }

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {(coelhos * 100.0 / total):F2} %");
        Console.WriteLine($"Percentual de ratos: {(ratos * 100.0 / total):F2} %");
        Console.WriteLine($"Percentual de sapos: {(sapos * 100.0 / total):F2} %");

    }

}