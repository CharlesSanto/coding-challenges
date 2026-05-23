using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0) break;

            Console.WriteLine(
                string.Join(" ", Enumerable.Range(1, n))
            );
        }

    }

}