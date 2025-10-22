using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais_polimorfismo
{
    internal class Passaro: Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"O {Nome} fez um som");
        }

        public override void Mover()
        {
            Console.WriteLine($"O {Nome} se moveu");
        }
    }
}
