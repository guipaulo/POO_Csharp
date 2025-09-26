using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace POO_25._09
{
    internal class Animal
    {
        public string nome;
        public string especie;
        public int idade;
        public bool EstaDormindo;

        public Animal (string nome, string especie, int idade) 
        { 
            this.nome = nome;
            this.especie = especie;
            this.idade = idade;
            EstaDormindo = false;
        }

        public void dormir ()
        {
            EstaDormindo = true;
            Console.WriteLine("O animal está dormindo");
        }

        public void acordar()
        {
            EstaDormindo = false;
            Console.WriteLine("O animal acordou");
        }

        public void fazerSom()
        {
            Console.WriteLine("O animal fez som!");
        }

        public void apresentarSe()
        {
            Console.WriteLine (this.nome);
            Console.WriteLine(this.especie);
            Console.WriteLine(this.idade);
        }
    }
}
