using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape {Nome = "Forma Genérica" };
            s1.Draw();

            Square sq1 = new Square {Nome = "Quadrado" };
            sq1.Draw();

            Circle c1 = new Circle { Nome = "Circulo" };
            c1.Draw();

            Triangle tri = new Triangle { Nome = "Triangulo" };
            tri.Draw();
        }
    }
}
