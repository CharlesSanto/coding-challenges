using System; 

class URI {

    static void Main(string[] args) { 

        var valores = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(valores[0]);
        int minutoInicial = int.Parse(valores[1]);
        int horaFinal = int.Parse(valores[2]);
        int minutoFinal = int.Parse(valores[3]);

        var (horas, minutos) = CalcularTempo(horaInicial, minutoInicial, horaFinal, minutoFinal);
        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");

    }

    public static (int, int) CalcularTempo(int horaInicial, int minutoInicial, int horaFinal, int minutoFinal)
    {

        int minutosInicial = horaInicial * 60 + minutoInicial;
        int minutosFinal = horaFinal * 60 + minutoFinal;

        if (minutosFinal <= minutosInicial)
        {
            minutosFinal += 24 * 60;
        }

        int diferencaMinutos = minutosFinal - minutosInicial;
        int horas = diferencaMinutos / 60;
        int minutos = diferencaMinutos % 60;

        return (horas, minutos);
    }

}