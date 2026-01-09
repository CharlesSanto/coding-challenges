using System; 

class URI {

    static void Main(string[] args) { 

        int id = int.Parse(Console.ReadLine());
        int hoursWorked = int.Parse(Console.ReadLine());
        double valuePerHour = double.Parse(Console.ReadLine());
        
        double salary = hoursWorked * valuePerHour;
        
        Console.WriteLine($"NUMBER = {id}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");

    }

}