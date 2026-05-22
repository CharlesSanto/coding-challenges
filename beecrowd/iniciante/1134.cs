using System; 

class URI {

    static void Main(string[] args) { 

        int alcohol = 0, gasoline = 0, diesel = 0;

        while (true)
        {
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    alcohol++;
                    break;
                case 2:
                    gasoline++;
                    break;
                case 3:
                    diesel++;
                    break;
                case 4:
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine($"Alcool: {alcohol}");
                    Console.WriteLine($"Gasolina: {gasoline}");
                    Console.WriteLine($"Diesel: {diesel}");
                    return;
            }
        }
    }

}