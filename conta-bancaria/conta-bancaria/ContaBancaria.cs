using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_bancaria
{
    public class ContaBancaria
    {
        public double Saldo {  get; private set; }

        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {this.Saldo}");
        }
    }
}
