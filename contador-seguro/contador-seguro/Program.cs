using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_seguro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContadorSeguro contador1 = new ContadorSeguro(100);

            contador1.Incrementar();
            contador1.ObterContador();

            contador1.Incrementar();
            contador1.Incrementar();
            contador1.Incrementar();
            contador1.ObterContador();

            contador1.Decrementar();
            contador1.Decrementar();
            contador1.ObterContador();

            contador1.Resetar();
            contador1.ObterContador();
        }
    }
}
