using System; 

class URI {

    static void Main(string[] args) { 

        int value1 = int.Parse(Console.ReadLine());
        int value2 = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = Math.Min(value1, value2); i <= Math.Max(value1, value2); i++)
        {
            if (i % 13 != 0) sum += i;
        }
        Console.WriteLine(sum);
    }

}