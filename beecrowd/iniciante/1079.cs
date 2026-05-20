using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 0; i < value; i++) {
            var input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            Console.WriteLine(Media(a, b, c).ToString("F1"));
        }
    }

    public static double Media(double a, double b, double c) {
        return (a * 2 + b * 3 + c * 5) / 10;
    }

}