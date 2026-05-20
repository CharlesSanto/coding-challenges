using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 1; i <= value; i += 2) {

            if (i % 2 != 0) {

                Console.WriteLine(i);
            }
        }
    }
}