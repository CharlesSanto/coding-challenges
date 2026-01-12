using System; 

class URI {

    static void Main(string[] args) { 

        var valores =  Console.ReadLine().Split(' ');
        
        int v1 = int.Parse(valores[0]);
        int v2 = int.Parse(valores[1]);
        
        if (v1 % v2 == 0 || v2 % v1 == 0)
            Console.WriteLine("Sao Multiplos");
        else 
            Console.WriteLine("Nao sao Multiplos");

    }

}