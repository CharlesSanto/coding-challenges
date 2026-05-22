using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++) {

            string[] values = Console.ReadLine().Split(' ');

            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);

            if (b == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double result = (double)a / b;
                Console.WriteLine(result.ToString("F1"));
            }
        }

    }

}