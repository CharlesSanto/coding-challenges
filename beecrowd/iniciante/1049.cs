using System;

class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        switch (a)
        {
            case "vertebrado":

                switch (b)
                {
                    case "ave":
                        Console.WriteLine(c == "carnivoro" ? "aguia" : "pomba");
                        break;

                    case "mamifero":
                        Console.WriteLine(c == "onivoro" ? "homem" : "vaca");
                        break;
                }

                break;

            case "invertebrado":

                switch (b)
                {
                    case "inseto":
                        Console.WriteLine(c == "hematofago" ? "pulga" : "lagarta");
                        break;

                    case "anelideo":
                        Console.WriteLine(c == "hematofago" ? "sanguessuga" : "minhoca");
                        break;
                }

                break;
        }
    }
}