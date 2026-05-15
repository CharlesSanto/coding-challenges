using System; 

class URI {

    static void Main(string[] args) { 

        double salario = double.Parse(Console.ReadLine());

        int percentual = 
            salario >= 0 && salario <= 400.00 ? 15 :
            salario > 400.00 && salario <= 800.00 ? 12 :
            salario > 800.00 && salario <= 1200.00 ? 10 :
            salario > 1200.00 && salario <= 2000.00 ? 7 : 4;

        double reajuste = salario * percentual / 100;
        double novoSalario = salario + reajuste;

        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
        Console.WriteLine($"Em percentual: {percentual} %");

    }

}