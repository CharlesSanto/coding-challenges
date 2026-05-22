using System; 

class URI {

    static void Main(string[] args) { 

        int maior = 0, posicao = 0;

        for (int i = 0; i < 100; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            if (valor > maior)
            {
                maior = valor;
                posicao = i + 1;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);

    }

}