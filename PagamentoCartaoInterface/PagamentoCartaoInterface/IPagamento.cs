using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoCartaoInterface
{
    internal interface IPagamento
    {
        double ValorTransacao {get;}
        bool ProcessarPagamento(double valor);
        string ObterComprovante();
        void CancelarTransacao();
    }
}
