using System; 

class URI {

    static void Main(string[] args) { 

       var input = Console.ReadLine().Split(' ');
       var M = int.Parse(input[0]);
       var N = int.Parse(input[1]);       

        while (M > 0 && N > 0) {
            var sum = 0;
            var min = Math.Min(M, N);
            var max = Math.Max(M, N);

            for (var i = min; i <= max; i++) {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine($"Sum={sum}");
            
            input = Console.ReadLine().Split(' ');
            M = int.Parse(input[0]);
            N = int.Parse(input[1]);
        }
} 

}