using System; 

class URI {

    static void Main(string[] args) { 

        double S = 1;
        double j = 2;

        for (int i = 3; i <= 39; i += 2) {

            S +=  i / (double)j;
            j = j * 2;
        }

        Console.WriteLine(S.ToString("F2"));
    }

}