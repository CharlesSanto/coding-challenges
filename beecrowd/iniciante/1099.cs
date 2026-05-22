using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 0; i < value; i++)
        {
            var input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            int sum = 0;

            for (int j = Math.Min(x, y) + 1; j < Math.Max(x, y); j++)
            {
                if (j % 2 != 0)
                {
                    sum += j;
                }
            }
            Console.WriteLine(sum);
        }

    }

}