using System; 

class URI {

    static void Main(string[] args) { 

        var values = Console.ReadLine().Split(' ');
        var X = int.Parse(values[0]);
        var Y = int.Parse(values[1]);

        while (X != Y)
        {

            string result = X < Y ? "Crescente" : "Decrescente";
            Console.WriteLine(result);

            values = Console.ReadLine().Split(' ');
            X = int.Parse(values[0]);
            Y = int.Parse(values[1]);
        }

    }

}