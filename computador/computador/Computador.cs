using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computador
{
    internal class Computador
    {
        private Processador processador;
        private MemoriaRAM memoria;

        public Computador (Processador processador, MemoriaRAM memoria)
        {
            this.processador = processador;
            this.memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Computador ligando...");
            processador.Processar();
            memoria.AlocarMemoria();
        }
    }
}
