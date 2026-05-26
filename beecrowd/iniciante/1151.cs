using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());

        Fibonacci(x);

    }

    public static void Fibonacci(int n) {
        int a = 0, b = 1;
        
        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
            {
                Console.WriteLine(a);
                break;
            }
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }

}