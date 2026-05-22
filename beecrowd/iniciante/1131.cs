using System; 

class URI {

    static void Main(string[] args) { 

        int option = 0;
        int interWins = 0, gremioWins = 0, draws = 0;

        do {
            var input = Console.ReadLine().Split(' ');
            int intScore = int.Parse(input[0]);
            int gremioScore = int.Parse(input[1]);

            if (intScore == gremioScore) {
                draws++;
            } else if(intScore > gremioScore) {
                interWins++;
            } else {
                gremioWins++;
            }

            do {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                option = int.Parse(Console.ReadLine());
            } while (option != 1 && option != 2);

        } while (option == 1);

        string winMost = interWins > gremioWins 
            ? "Inter venceu mais" 
            : (gremioWins > interWins ? "Gremio venceu mais" 
            : "Nao houve vencedor");

        Console.WriteLine($"{interWins + gremioWins + draws} grenais");
        Console.WriteLine($"Inter:{interWins}");
        Console.WriteLine($"Gremio:{gremioWins}");
        Console.WriteLine($"Empates:{draws}");
        Console.WriteLine(winMost);
    }
}