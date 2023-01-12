using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviao_de_POO.Model
{
    public class Aluno : Pessoa 
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {

        }

        public void IrParaEscola()
        {
            Console.WriteLine("Indo para escola");
        }

    }
}
