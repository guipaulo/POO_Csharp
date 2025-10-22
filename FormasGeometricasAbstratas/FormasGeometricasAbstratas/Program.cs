using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo {Largura = 10, Altura = 5, Cor = "Laranja" };
            Console.WriteLine(r1.CalcularArea());
            Console.WriteLine(r1.CalcularPerimetro());
            r1.Pintar();
            r1.Desenhar();

            Circulo c1 = new Circulo {Raio = 8, Cor = "Azul"};
            Console.WriteLine(c1.CalcularArea());
            Console.WriteLine(c1.CalcularPerimetro());
            c1.Pintar();
            c1.Desenhar();
        }
    }
}
