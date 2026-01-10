using System; 

class URI {

    static void Main(string[] args) { 

        var peca1 = Console.ReadLine().Split(' ');
        int id1 = int.Parse(peca1[0]);
        int numbers1 = int.Parse(peca1[1]);
        double unitary1 = double.Parse(peca1[2]);
        
        var peca2 = Console.ReadLine().Split(' ');
        int id2 = int.Parse(peca2[0]);
        int numbers2 = int.Parse(peca2[1]);
        double unitary2 = double.Parse(peca2[2]);
        
        double result = (numbers1 * unitary1) + (numbers2 * unitary2);
        
        Console.WriteLine($"VALOR A PAGAR: R$ {result:F2}");
    }

}