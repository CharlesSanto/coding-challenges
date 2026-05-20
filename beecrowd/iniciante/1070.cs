using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());
        
        if (value % 2 == 0) value++;

        for (int i = 0; i < 6; i++) {
            Console.WriteLine(value);
            value += 2;
        }

    }

}