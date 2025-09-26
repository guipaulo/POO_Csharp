using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2POO
{
    internal class ContaBancaria
    {
        private double saldo;
        public string NumeroConta;
        public string NomeTitular;

        public ContaBancaria(double saldo, string numeroConta, string nomeTitular)
        {
            this.saldo = saldo;
            this.NumeroConta = numeroConta;
            this.NomeTitular = nomeTitular;
        }

        public void depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Não é permitido depositos nulos ou negativos");
            }
            this.saldo += valor;
        }
        public void sacar(double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            this.saldo -= valor;
        }
        public double ConsultarSaldo ()
        {
            return this.saldo;
        }
        public void ExibirExtrato()
        {
            Console.WriteLine(this.NomeTitular);
            Console.WriteLine(this.NumeroConta);
            Console.WriteLine(this.saldo);
        }
    }
}
