using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Class
{
    public class Mammal : Animal
    {
        int qtyBoobs { get; set; }
        string furColor { get; set; }

        public Mammal(string name, DateTime birthDate, char genre, int age, int qtyBoobs) : base(name, birthDate, genre, age)
        {
            this.age = age;
            this.birthDate = birthDate;
            this.genre = genre;
            this.age = age;
            this.qtyBoobs = qtyBoobs;
            this.furColor = "no";
        }

        public bool Fur(string haveFur)
        {
            if (haveFur == "yes")
            {
                Console.WriteLine("What's the fur color?");
                string? inputFur = Console.ReadLine();
                furColor = inputFur;
                return true;
            }
            return false;
        }

        public void Breastfeed()
        {
            Console.WriteLine("I'm breastfeeding!");
        }

        

    }
}
