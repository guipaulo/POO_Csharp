using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculos
{
    public class Veiculo
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int Ano {  get; set; }
        protected int Velocidade = 0;

        public virtual void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine($"Acelerando. Velocidade = {Velocidade} km/h");
        }

        public virtual void Frear()
        {
            Velocidade = Math.Max(0, Velocidade - 10);
            Console.WriteLine($"Freando. Velocidade: {Velocidade} km/h");
        }
    }
}
