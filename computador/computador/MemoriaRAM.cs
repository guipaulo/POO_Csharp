using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computador
{
    internal class MemoriaRAM
    {
        public int Capacidade {  get; set; }

        public void AlocarMemoria()
        {
            Console.WriteLine($"Alocando memória: {Capacidade} GB");
        }
    }
}
