using System; 

class URI {

    static void Main(string[] args) { 

        int value1 = int.Parse(Console.ReadLine());
        int value2 = int.Parse(Console.ReadLine());

        for (int i = Math.Min(value1, value2) + 1; i < Math.Max(value1, value2); i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }

    }

}