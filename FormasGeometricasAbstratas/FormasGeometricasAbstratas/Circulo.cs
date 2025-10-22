using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasAbstratas
{
    internal class Circulo:Forma
    {
        public double Raio;

        public override double CalcularArea()
        {
            return 3.14 * Math.Pow(Raio, 2);
        }
        public override double CalcularPerimetro()
        {
            return 2 * 3.14*Raio;
        }
        public override void Desenhar()
        {
            Console.WriteLine($"Você desenhou um circulo de raio {Raio}");
        }
    }
}
