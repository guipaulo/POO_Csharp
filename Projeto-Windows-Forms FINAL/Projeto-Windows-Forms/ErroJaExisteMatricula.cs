using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms
{
    // Exceção de Erro de Campo Vazio que herda de Exception
    public class ErroJaExisteMatricula : Exception
    {
        public ErroJaExisteMatricula(string msg) : base(msg) { }
    }
}
