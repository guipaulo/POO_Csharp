using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livros_poo
{
    internal class Livro
    {
        public string titulo;
        public string autor;
        public int paginas;
        public int paginaAtual = 0;

        public Livro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;

        }

        public void LerPagina()
        {
            this.paginaAtual++;
        }

        public void ObterProgresso()
        {
            Console.WriteLine($"Você leu {paginaAtual} páginas de {paginas} páginas");
        }

        public void ReiniciarLeitura()
        {
            paginaAtual = 1;
        }
    }
}
