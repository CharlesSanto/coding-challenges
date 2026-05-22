using System; 

class URI {

    static void Main(string[] args) { 

        int valid = 0;
        double sum = 0;

        while (valid < 2) {

            double n = double.Parse(Console.ReadLine());

            if (n >= 0 && n <= 10) {
                valid++;
                sum += n;
            } else {
                Console.WriteLine("nota invalida");
            }
        }
        Console.WriteLine("media = " + (sum / 2).ToString("F2"));
    }
}