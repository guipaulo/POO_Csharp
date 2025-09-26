using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_25._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Mimi", "Felino", 3);
            Animal a2 = new Animal("Rex", "Canino", 3);
            Animal a3 = new Animal("Piu", "Ave", 1);

            a1.dormir();
            a2.acordar();
            a3.fazerSom();
            a1.apresentarSe();
        }
    }
}
