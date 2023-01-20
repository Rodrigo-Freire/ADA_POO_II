using Treinando_interfaces_com_Animais.Class.Animals;

namespace Treinando_interfaces_com_Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Leão";
            DateTime birthDate = new DateTime(2020, 01, 01);
            char genre = 'M';
            int age = 10;

            Lion leao = new Lion(Name, birthDate, genre, age, 12);

            Console.WriteLine($"Eu sou um {leao.Name}" +
                $"\nNascido em {leao.birthDate.ToString()}" +
                $"\nDo genero {leao.genre}" +
                $"\nTenho {leao.age.ToString()} anos" +
                $"\nAs fêmas da minha espécie tem {leao.qtyBoobs} mamas");



    }
    }
}