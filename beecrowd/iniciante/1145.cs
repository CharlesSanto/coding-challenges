using System; 

class URI {

    static void Main(string[] args) { 

        var valores = Console.ReadLine().Split(' ');
        var x = int.Parse(valores[0]);  
        var y = int.Parse(valores[1]);

        for (int i = 1; i <= y; i += x)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(i + j);
                if (j < x - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

    }

}