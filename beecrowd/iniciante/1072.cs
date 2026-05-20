using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());
        int inCount = 0;
        int outCount = 0;

        for (int i = 0; i < value; i++) {
            int number = int.Parse(Console.ReadLine());
            if (number >= 10 && number <= 20) {
                inCount++;
            } else {
                outCount++;
            }
        }
        Console.WriteLine($"{inCount} in");
        Console.WriteLine($"{outCount} out");

    }

}