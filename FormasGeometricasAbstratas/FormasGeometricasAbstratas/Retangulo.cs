using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasAbstratas
{
    internal class Retangulo: Forma
    {
        public double Largura {  get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Largura*Altura;
        }
        public override double CalcularPerimetro()
        {
            return 2*(Altura*Largura);
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um retângulo de {Largura}x{Altura}");
        }
    }
}
