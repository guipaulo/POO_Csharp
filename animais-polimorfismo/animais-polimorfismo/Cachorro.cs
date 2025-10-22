using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais_polimorfismo
{
    internal class Cachorro: Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"O {Nome} faz: Au au");
        }

        public override void Mover()
        {
            Console.WriteLine($"O {Nome} se move");
        }
    }
}
