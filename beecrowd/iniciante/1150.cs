using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());
        int z = 0;

        while (x >= z) 
            z = int.Parse(Console.ReadLine());

        int count = 0;
        int sum = 0;

        for (int i = x; i < z; i++)
        {
            sum += i;
            count += 1;

            if (sum > z) break;
        }

        Console.WriteLine(count);

    }

}