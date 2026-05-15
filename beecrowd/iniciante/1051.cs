using System; 

class URI {

    static void Main(string[] args) { 

        double salario = double.Parse(Console.ReadLine());
        double imposto = 0;

        if (salario > 4500.00) {
            imposto += (salario - 4500.00) * 0.28;
            salario = 4500.00;
        }

        if (salario > 3000.00) {
            imposto += (salario - 3000.00) * 0.18;
            salario = 3000.00;
        }
        
        if (salario > 2000.00) {
            imposto += (salario - 2000.00) * 0.08;
        }

        if (imposto == 0) {
            Console.WriteLine("Isento");
        }
        else {
            Console.WriteLine($"R$ {imposto:F2}");
        }

    
    }

}