using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_seguro
{
    public class ContadorSeguro
    {
        private int contador = 0;
        private int valorMaximo;

        public ContadorSeguro(int valorMax)
        {
            this.valorMaximo = valorMax;
        }

        public void Incrementar()
        {
            if (this.contador < valorMaximo)
            {
                this.contador++;
            }
            else
            {
                Console.WriteLine("Valor máximo atingido");
            }
        }

        public void Decrementar()
        {
            if (this.contador > 0)
            {
                this.contador--;
            }
            else
            {
                Console.WriteLine("Valor mínimo atingido");
            }
        }

        public void ObterContador()
        {
            Console.WriteLine($"Valor atual do contador: {this.contador} de {valorMaximo}");
        }

        public void Resetar()
        {
            this.contador = 0;
        }
    }
}
