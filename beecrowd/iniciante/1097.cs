using System; 

class URI {

    static void Main(string[] args) { 

        int j = 7;

        for (int i = 1; i <= 9; i += 2)
        {
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
            }

            j += 5;
        }

    }

}