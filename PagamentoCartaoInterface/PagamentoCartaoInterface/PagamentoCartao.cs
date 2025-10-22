using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoCartaoInterface
{
    internal class PagamentoCartao: IPagamento
    {
        public double ValorTransacao { get; set; }
        private string NumeroCartao;

        public PagamentoCartao(string numeroCartao)
        {
            this.NumeroCartao = numeroCartao;
        }

        public bool ProcessarPagamento(double valor)
        {
            ValorTransacao = valor;
            Console.WriteLine($"Processando pagamento de R$ {valor} no cartão {this.NumeroCartao}");
            return true;
        }

        public string ObterComprovante()
        {
            return $"Pagamento de {ValorTransacao}";
        }

        public void CancelarTransacao()
        {
            Console.WriteLine("Estornando valor no cartão");
        }
    }
}
