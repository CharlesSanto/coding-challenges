using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(Fatorial(x));
    }

    public static int Fatorial(int n) {
        if (n == 0 || n == 1) {
            return 1;
        }
        return n * Fatorial(n - 1);
    }

}