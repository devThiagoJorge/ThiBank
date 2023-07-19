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
    }
}
