using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 2; i <= value; i += 2)
        {
            Console.WriteLine($"{i}^2 = {i * i}");
        }
    }

}