using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioPOO
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public int paginas;
        public int paginaAtual;

        public Livro (string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
            paginaAtual = 1;
        }

        public void LerPagina()
        {
            paginaAtual++;
        }

        public double ObterProgresso()
        {
            return (paginaAtual / paginas) * 100;
        }

        public double ReiniciarLeitura()
        {
            return paginaAtual = 1;
        }
    }
}
