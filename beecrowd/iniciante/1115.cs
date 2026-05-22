using System; 

class URI {

    static void Main(string[] args) { 

        while (true) {
            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            if (x == 0 || y == 0) {
                break;
            }

            string quadrante = x > 0 
                ? (y > 0 ? "primeiro" : "quarto")
                : (y > 0 ? "segundo" : "terceiro");

            Console.WriteLine(quadrante);
        }

    }

}