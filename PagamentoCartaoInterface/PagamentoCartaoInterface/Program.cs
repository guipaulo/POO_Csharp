using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoCartaoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PagamentoCartao Pag1 = new PagamentoCartao("2254898741523697");
            Pag1.ProcessarPagamento(50);
            Console.WriteLine(Pag1.ObterComprovante());
            Pag1.CancelarTransacao();
        }
    }
}
