using Reviao_de_POO.Model;

namespace Reviao_de_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mudando a cor da fonte no console
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            //instanciando a Class Pessoa para criar uma nova pessoa
            Pessoa novaPessoa = new Pessoa("Alicia", 35);

            //chamando os metodos de saudações
            novaPessoa.Cumprimentar();
            novaPessoa.DizerIdade();
            Console.WriteLine();

            //instanciando a Class Aluno que herda a Class Pessoa para criar um novo Aluno
            Aluno aluno = new Aluno("Raquel", 21);

            //chamando o método que leva o aluno para escola
            aluno.IrParaEscola();

            //chamando os metodos de saudações
            aluno.Cumprimentar();
            aluno.DizerIdade();
            Console.WriteLine();

            //instanciando a Class Professor que herda a Class Pessoa para criar um novo Professor
            Professor professor = new Professor("Julio", 30, "Exclusão Social");

            //chamando os metodos de saudações
            professor.Cumprimentar();
            professor.DizerIdade();

            //chamando o metodo do Assunto
            professor.explicaAssunto();

            Console.ReadKey();


        }
    }
}