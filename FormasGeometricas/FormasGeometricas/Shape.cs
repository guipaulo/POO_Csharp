using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Shape
    {
        public string Nome {  get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Você fez um desenho");
        }
    }
}
