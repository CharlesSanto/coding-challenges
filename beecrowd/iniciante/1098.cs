using System; 

class URI {

    static void Main(string[] args) { 

        for (double i = 0; i <= 20; i += 2)
        {
            for (double j = 1; j <= 3; j++)
            { 

                double I = i / 10;
                double J = I + j;

                if (I == 0 || I == 1 || I == 2)
                {
                    Console.WriteLine($"I={(int)I} J={(int)J}");
                }
                else
                {
                    Console.WriteLine($"I={I} J={J}");
                }
            }
        }

    }

}