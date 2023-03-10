using Treinando_interfaces_com_Animais.Class.Animals;

namespace Treinando_interfaces_com_Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            

            string Name = "Leão";
            DateTime birthDate = new DateTime(2020, 01, 01);
            char genre = 'M';
            int age = 10;

            Lion leao = new Lion(Name, birthDate, genre, age, 12);

            Console.WriteLine($"Eu sou um {leao.Name}" +
                $"\nNascido em {leao.birthDate.ToString()}" +
                $"\nDo genero {leao.genre}" +
                $"\nTenho {leao.age.ToString()} anos" +
                $"\nAs fêmas da minha espécie tem {leao.qtyBoobs} mamas\n");

            Name = "Cisne";
            Cisne cisne = new Cisne(Name, birthDate, genre, age);
            Console.WriteLine($"Eu sou um {cisne.Name}" +
                $"\nNascido em {cisne.birthDate.ToString()}" +
                $"\nDo genero {cisne.genre}" +
                $"\nTenho {cisne.age.ToString()} anos\n");

            cisne.Flying();
            cisne.Lay();
            cisne.Hatch(); 
            



        }
    }
}