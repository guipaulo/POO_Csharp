using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasAbstratas
{
    internal abstract class Forma
    {
        public string Cor {  get; set; }

        public void Pintar()
        {
            //Metodo concreto
            Console.WriteLine($"Pintando a forma de {Cor}");
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public abstract void Desenhar();
    }
}
