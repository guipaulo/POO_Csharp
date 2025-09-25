using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro L1 = new Livro("Harry Potter", "Ellen Mayara", 25);

            L1.LerPagina();
            L1.LerPagina();
            L1.LerPagina();
            L1.LerPagina();
            L1.LerPagina();

            Console.WriteLine(L1.paginaAtual);

            L1.ReiniciarLeitura();
            Console.WriteLine(L1.paginaAtual);

            Console.WriteLine(L1.ObterProgresso());
        }
    }
}
