using System; 

class URI {

    static void Main(string[] args) { 

        int pares = 0;

        for (int i = 0; i < 5; i++) 
        {
            double value = double.Parse(Console.ReadLine());

            if (value % 2 == 0) 
            {
                pares++;
            }
        }

        Console.WriteLine($"{pares} valores pares");

    }

}