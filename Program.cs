using System;

namespace Idade_para_torneios
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            string resposta;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Ola, "+nome+"!");
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você gostaria de participar da nossa equipe da escola de CS GO? [SIM] ou [NÃO]");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                while (resposta != "SIM" && resposta != "NÂO")
                {  
                    Console.WriteLine("resposta inválida, apenas [SIM] ou [NÃO]");
                    resposta = Console.ReadLine();
                    resposta = resposta.ToUpper();
                }
                if (resposta == "SIM")
                {
                    Console.WriteLine("Certo, para se inscrever, vá ate a secretaria. Obrigado!");
                }
                if (resposta == "NÂO")
                {
                    Console.WriteLine("Que pena! caso mude de ideia, consulte a secretaria.");
                }
            }
            if (idade < 18)
            {
                Console.WriteLine("Você gostaria de participar da nossa equipe da escola de LOL? [SIM] ou [NÃO]");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                while (resposta != "SIM" && resposta != "NÂO")
                {  
                    Console.WriteLine("resposta inválida, apenas [SIM] ou [NÃO]");
                    resposta = Console.ReadLine();
                    resposta = resposta.ToUpper();
                }
                if (resposta == "SIM")
                {
                    Console.WriteLine("Certo, para se inscrever, vá ate a secretaria. Obrigado!");
                }
                if (resposta == "NÂO")
                {
                    Console.WriteLine("Que pena! caso mude de ideia, consulte a secretaria.");
                }
            }
        }
    }
}
