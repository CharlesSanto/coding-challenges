using System; 

class URI {

    static void Main(string[] args) { 

        int senha = 2002;
        bool acessoPermitido = false;

        while (!acessoPermitido) {
            int entrada = int.Parse(Console.ReadLine());

            string resposta = (entrada == senha) ? "Acesso Permitido" : "Senha Invalida";
            Console.WriteLine(resposta);

            if (entrada == senha) acessoPermitido = true;
        }

    }

}