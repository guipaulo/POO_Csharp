using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livros_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro liv1 = new Livro("A culpa é das estrelas", "John Green", 288);
            Livro liv2 = new Livro("Harry Potter e a Pedra Filosofal", "J. K. Rowling", 263);
            Livro liv3 = new Livro("As Crônicas de Nárnia", "C. S. Lewis", 528);

            liv1.LerPagina();
            liv1.LerPagina();
            liv1.LerPagina();
            liv1.LerPagina();
            liv1.LerPagina();

            liv1.ObterProgresso();

            liv2.LerPagina();
            liv2.LerPagina();
            liv2.LerPagina();
            liv2.LerPagina();

            liv2.ObterProgresso();

            liv3.LerPagina();
            liv3.LerPagina();
            liv3.LerPagina();

            liv3.ObterProgresso();
            liv3.ReiniciarLeitura();
            liv3.ObterProgresso();
        }
    }
}
