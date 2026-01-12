using System; 

class URI {

    static void Main(string[] args) { 

        var valores = Console.ReadLine().Split(' ');
        
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        
        int[] original = {a, b, c};
        
        int[] ordenado = {a, b, c};
        
        Array.Sort(ordenado);
        
        foreach(int v in ordenado)
        {
            Console.WriteLine(v);
        }
        
        Console.WriteLine();
        
        foreach(int v in original)
        {
            Console.WriteLine(v);
        }

    }

}