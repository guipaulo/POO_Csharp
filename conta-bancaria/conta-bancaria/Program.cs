using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta1 = new ContaBancaria(1000);

            Conta1.Sacar(200);
            Conta1.ExibirSaldo();

            Conta1.Depositar(100);
            Conta1.ExibirSaldo();
        }
    }
}
