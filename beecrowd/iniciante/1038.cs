using System; 

class URI {

    static void Main(string[] args) { 
     
        var valores = Console.ReadLine().Split(' ');
        
        int codigo = int.Parse(valores[0]);
        int quantidade = int.Parse(valores[1]);
        
        double preco = 0.0;
        
        if (codigo == 1)
            preco = 4.00;
        else if (codigo == 2)
            preco = 4.50;
        else if (codigo == 3)
            preco = 5.00;
        else if (codigo == 4)
            preco = 2.00;
        else if (codigo == 5)
            preco = 1.50;
            
        double total = quantidade * preco;
        
        Console.WriteLine($"Total: R$ {total:F2}");
           
    }
}