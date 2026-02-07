using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms
{
    // Exceção de Erro de Não Existe Professor que herda de Exception
    public class ErroNaoExisteProfessor: Exception
    {
        public ErroNaoExisteProfessor(string msg) : base(msg) { }
    }
}
