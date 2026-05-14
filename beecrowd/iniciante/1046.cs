using System; 

class URI {

    static void Main(string[] args) {        
        
        var valores = Console.ReadLine().Split(' ');

        int valorInicial = int.Parse(valores[0]);
        int valorFinal = int.Parse(valores[1]);        

        Console.WriteLine($"O JOGO DUROU {CalcularTempo(valorInicial, valorFinal)} HORA(S)");

    }

    public static int CalcularTempo(int valorInicial, int valorFinal)
    {
        if (valorInicial < valorFinal)
            return valorFinal - valorInicial;
        else
            return 24 - valorInicial + valorFinal;
    }

}