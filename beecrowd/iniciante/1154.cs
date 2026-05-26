using System; 

class URI {

    static void Main(string[] args) { 

        int sum  = 0;
        int count = 0;

        while (true)
        {
            int x = int.Parse(Console.ReadLine());

            if (x < 0) break;

            sum += x;
            count++;
        };

        double average = (double)sum / count;
        Console.WriteLine($"{average:F2}");

    }

}