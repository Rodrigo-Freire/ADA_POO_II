using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Class
{
    public class Bird : Animal
    {
        public Bird (string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
        {
            this.age = age;
            this.birthDate = birthDate;
            this.genre = genre;
            this.age = age;
        }

        public void Scratch()
        {
            Console.WriteLine("I'm pecking!");
        }

        public bool Prey(string isHunter)
        {
            if (isHunter == "yes")
            {
                Console.WriteLine("I'm a bird of prey!");
                return true;
            }
            return false;
        }

        public bool FeatherColor(string haveTwoCollors)
        {
            if (haveTwoCollors == "yes")
            {
                Console.WriteLine("I'm a colorfiç bird!");
                return true;
            }
            return false;
            
        }
    }
}
