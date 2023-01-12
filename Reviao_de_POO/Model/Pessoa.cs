using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviao_de_POO.Model
{
    public class Pessoa
    {
        public string nome { get; set; }    
        public int idade { get; set; }

        public Pessoa(string nome, int idade) 
        {
            this.nome = nome;
            this.idade = idade; 
        }


        public void Cumprimentar ()
        {
            Console.WriteLine($"Olá meu nome é {nome}.");
        }

        public void DizerIdade ()
        {
            Console.WriteLine($"Eu tenho {idade} anos de idade!");
        }
    }
}
