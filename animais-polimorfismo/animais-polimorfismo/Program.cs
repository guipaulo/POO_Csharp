using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais_polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal an1 = new Animal {Nome = "Chico" };
            an1.FazerSom();
            an1.Mover();

            Cachorro ca1 = new Cachorro {Nome = "Xburger" };
            ca1.FazerSom();
            ca1.Mover();

            Passaro pa1 = new Passaro { Nome = "Foguinho" };
            pa1.FazerSom();
            pa1.Mover();
        }
    }
}
