using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 1; i <= value; i++) {

            Console.WriteLine($"{(i * 4) - 3} {(i * 4) - 2} {(i * 4) - 1} PUM");

        }
    }

}