using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 2; i <= 10000; i++)
        {
            if (i % value == 2)
            {
                Console.WriteLine(i);
            }
        }

    }

}