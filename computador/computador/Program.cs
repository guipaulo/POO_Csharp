using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Processador cpu1 = new Processador({ Modelo = "Ryzen 5", Velocidade = 3.8 });
            
            Computador pc1 = new Computador(new Processador { Modelo = "Intel i5", Velocidade = 3.2 },
                new MemoriaRAM { Capacidade = 8 });
            Computador pc2 = new Computador(new Processador { Modelo = "AMD Ryzen 5", Velocidade = 3.8 },
                new MemoriaRAM { Capacidade = 16 });

            pc1.Ligar();
            pc2.Ligar();



        }
    }
}
