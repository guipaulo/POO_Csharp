using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Forms
{
    // Exceção de Erro de Campo Vazio que herda de Exception
    public class ErroCampoVazio : Exception
    {
        public ErroCampoVazio (string msg): base(msg) { }
    }
}
