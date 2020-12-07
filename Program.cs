using System;
using AulaPOO_Heranca.classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            Console.Write("Digite seu nome: ");
            pf.nome = Console.ReadLine();
            pj.nome = pf.nome;
            Console.Clear();
            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            string escolha;

            do
            {
            Console.WriteLine("Você é Pessoa Física ou Jurídica? \n[F] - Física \n[J] - Jurídica\n[M] - Mostrar as Opções novamente\n[S] - Sair da Aplicação  ");
            escolha = Console.ReadLine();
            switch (escolha)
            {
                case "F":
                Console.Write("Digite seu CPF: ");
                pf.cpf = Console.ReadLine();
                pf.ValidarCPF(pf.cpf);
                    return;
                case "J":
                Console.Write("Digite seu CNPJ: ");
                pj.cnpj = Console.ReadLine();
                pj.ValidarCNPJ(pj.cnpj);
                Console.Write("Digite o número de Inscrição Estadual: ");
                pj.incricaoEstadal = Console.ReadLine();
                    return;
                case "S":
                Console.WriteLine("Muito Obrigado por Acessar\nVolte Sempre!");
                    return;    
                case "M": //Menu
                    break;    
                default:
                Console.WriteLine("Opcão Inválida!");
                    break;
            }
            } while (escolha != "S");
            
            

            
            
            
            
            
        }
    }
}
