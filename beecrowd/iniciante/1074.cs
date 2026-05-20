using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 0; i < value; i++) 
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0) Console.WriteLine("NULL");
            else if (number % 2 == 0 && number > 0) Console.WriteLine("EVEN POSITIVE");
            else if (number % 2 == 0 && number < 0) Console.WriteLine("EVEN NEGATIVE");
            else if (number % 2 != 0 && number > 0) Console.WriteLine("ODD POSITIVE");
            else if (number % 2 != 0 && number < 0) Console.WriteLine("ODD NEGATIVE");
        }

    }

}