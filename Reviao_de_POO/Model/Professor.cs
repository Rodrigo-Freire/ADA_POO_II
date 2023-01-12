using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviao_de_POO.Model
{
    public class Professor : Pessoa
    {
        string assunto { get; set; }
        public Professor(string nome, int idade, string assunto) : base(nome, idade) 
        {
            this.assunto = assunto;
        }

        public void explicaAssunto()
        {
            Console.WriteLine($"Hoje vamos falar sobre {assunto}.");
        }
               

    }
}
