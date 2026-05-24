using System;

class URI
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split();

        int a = int.Parse(valores[0]);

        int n = 0;
        
        for (int i = 1; i < valores.Length; i++)
        {
            int x = int.Parse(valores[i]);
            if (x > 0)
            {
                n = x;
                break;
            }
        }

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += a + i;
        }

        Console.WriteLine(sum);
    }
}