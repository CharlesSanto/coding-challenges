using System; 

class URI {

    static void Main(string[] args) { 

        int ddd = int.Parse(Console.ReadLine());

        string cidade = 
            ddd == 61 ? "Brasilia" :
            ddd == 71 ? "Salvador" :
            ddd == 11 ? "Sao Paulo" :
            ddd == 21 ? "Rio de Janeiro" :
            ddd == 32 ? "Juiz de Fora" :
            ddd == 19 ? "Campinas" :
            ddd == 27 ? "Vitoria" :
            ddd == 31 ? "Belo Horizonte" : "DDD nao cadastrado";

        Console.WriteLine(cidade);
    }

}