using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiBank.Classes;
using ThiBank.Enums;

namespace ThiBank
{
    public static class Main
    {
        public static void Iniciar()
        {
            string operacao = ObterOperacaoUsuario();
        }

        private static string ObterOperacaoUsuario()
        {
            Console.WriteLine("Seja bem vindo ao ThiBank!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Depositar");
            Console.WriteLine("5 - Limpar tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            RealizarOperacoes(opcaoUsuario);
            return opcaoUsuario;
        }

        private static void RealizarOperacoes(string operacao)
        {
            List<Conta> contas = new List<Conta>();
            while (operacao != "X")
            {
                switch (operacao)
                {
                    case "1":
                        ListarContas(contas);
                        break;
                    case "2":
                        var conta = InserirContas();
                        contas.Add(conta);
                        break;
                    default:
                        break;
                }
            }
        }

        private static Conta InserirContas()
        {
            Console.WriteLine("Informe o nome do usuário da conta.");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo da conta se é PF = 1 ou PJ = 2.");
            int tipoDaConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo inicial.");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de crédito especial.");
            double creditoEspecial = double.Parse(Console.ReadLine());

            var conta = new Conta(nome, creditoEspecial, saldo, (TipoConta)tipoDaConta);
            Console.WriteLine("A conta foi criada com sucesso!");
            Console.WriteLine(conta.ToString());
            return conta;

        }

        private static void ListarContas(List<Conta> contas)
        {
            if(contas.Count == 0)
            {
                Console.WriteLine("Não possui contas cadastradas!");
                return;
            }

            foreach (var conta in contas)
            {
                Console.WriteLine(conta.ToString());
                Console.WriteLine("------------------------");
            }
        }

    }
}
