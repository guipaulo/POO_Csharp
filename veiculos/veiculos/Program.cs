using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro {Marca = "Chevrolet", Modelo = "Corsa", Ano = 2011, NumeroPortas = 4 };

            carro1.AbrirPortas();
            carro1.Acelerar();
            carro1.Frear();
        }
    }
}
