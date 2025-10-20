using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computador
{
    internal class Processador
    {
        public string Modelo { get; set; }
        public double Velocidade { get; set; }

        public void Processar()
        {
            Console.WriteLine($"Processando com {Modelo} a {Velocidade}GHz");
        }
    }
}
