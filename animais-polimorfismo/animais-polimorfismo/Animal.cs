using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais_polimorfismo
{
    internal class Animal
    {
        public string Nome { get; set; }

        public virtual void FazerSom()
        {
            Console.WriteLine("O animal fez um som");
        }

        public virtual void Mover()
        {
            Console.WriteLine("O animal se move");
        }
    }
}
