using System; 

class URI {

    static void Main(string[] args) { 

        int totalSegundos = int.Parse(Console.ReadLine());
        
        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = (totalSegundos % 3600) % 60;
        
        Console.WriteLine($"{horas}:{minutos}:{segundos}");

    }

}