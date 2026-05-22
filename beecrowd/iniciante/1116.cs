using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++) {

            string[] values = Console.ReadLine().Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);

            var result = b == 0 ? "divisao impossivel" : ((double)a / b).ToString("F1");

            Console.WriteLine(result);
        }

    }

}