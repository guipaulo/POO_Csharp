using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculos
{
    public class Carro: Veiculo
    {
        public int NumeroPortas { get; set; }
        
        public void AbrirPortas()
        {
            Console.WriteLine("Abrindo portas do carro");
        }

        // Sobrescrevendo método da classe pai
        public override void Acelerar()
        {
            Velocidade += 15;
            Console.WriteLine($"Carro acelerando suavemente: {Velocidade} km/h");
        }
    }
}
