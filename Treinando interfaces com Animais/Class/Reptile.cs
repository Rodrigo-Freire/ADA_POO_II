using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Class
{
    public class Reptile : Animal
    {
        public Reptile(string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
        {
            this.age = age;
            this.birthDate = birthDate;
            this.genre = genre;
            this.age = age;
        }

        public static bool HaveScales(string scales)
        {
            if (scales == "yes")
            {
                Console.WriteLine("I have scales in my skin!");
                return true;
            }
            return false;
        }

        public static bool Hull(string haveHull)
        {
            if (haveHull == "yes")
            {
                Console.WriteLine("I'm an animal with hull!");
                return true;
            }
            return false;
        }
    }
}
