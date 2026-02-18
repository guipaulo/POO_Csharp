using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        public static void Desenhar(Shape forma)
        {
            forma.Draw();
        }
        static void Main(string[] args)
        {

            Shape[] formas = { new Shape(), new Square(), new Circle(), new Triangle() };

            foreach (Shape s in formas) 
            { 
                Desenhar(s);
            }
        }
    }
}
