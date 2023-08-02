using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiBank.Enums;

namespace ThiBank.Classes
{
    public class Conta
    {
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(string nome, double credito, double saldo, TipoConta tipoConta)
        {
            Nome = nome;
            Credito = credito;
            Saldo = saldo;
            TipoConta = tipoConta;
        }

        public bool Sacar(double valorSaque)
        {
            if(Saldo - valorSaque < Credito * -1)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

            Saldo -= valorSaque;
            Console.WriteLine($"O saldo da conta de {Nome} é R${Saldo}");
            return true;
        }
        
        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"O saldo da conta de {Nome} é R${Saldo}");
        }

        public void Transferencia(double valorTrasnferir, Conta contaDestino)
        {
            if (!Sacar(valorTrasnferir))
            {
                Console.WriteLine("Não foi possível transferir.");
            }
            contaDestino.Depositar(valorTrasnferir);
            Console.WriteLine("Tranferência concluída!");
        }

        public override string ToString()
        {
            var retornoConta = $"Nome: {Nome} | Tipo da conta: {TipoConta} | Quantidade de saldo especial: {Credito} | Saldo: {Saldo}";
            return retornoConta;
        }

    }
}
