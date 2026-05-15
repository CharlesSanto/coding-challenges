using System; 

class URI {

    static void Main(string[] args) { 
        
        int mes = int.Parse(Console.ReadLine());
        
        string nomeMes = 
            mes == 1 ? "January" :
            mes == 2 ? "February" :
            mes == 3 ? "March" :
            mes == 4 ? "April" :
            mes == 5 ? "May" :
            mes == 6 ? "June" :
            mes == 7 ? "July" :
            mes == 8 ? "August" :
            mes == 9 ? "September" :
            mes == 10 ? "October" :
            mes == 11 ? "November" : 
            "December";

        Console.WriteLine(nomeMes);

    }

}