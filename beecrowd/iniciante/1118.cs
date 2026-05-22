using System; 

class URI {

    static void Main(string[] args) { 

        int option;
        double sum;
        int count;

        do {
            sum = 0.0;
            count = 0;

            while (count < 2) {

                double number = double.Parse(Console.ReadLine());

                if (number >= 0 && number <= 10) {
                    sum += number;
                    count++;
                } else {
                    Console.WriteLine("nota invalida");
                }
            }

            Console.WriteLine($"media = {(sum / 2).ToString("F2")}");

            do {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                option = int.Parse(Console.ReadLine());
            } while (option != 1 && option != 2);

        } while (option == 1);
    }
}