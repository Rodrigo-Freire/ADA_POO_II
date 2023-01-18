using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Class
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public DateTime birthDate { get; set; }
        public char genre { get; set; }
        public int age { get; set; }
        public Animal(string name, DateTime birthDate, char genre, int age)
        {
            this.Name = name;
            this.age = age;
            this.birthDate = birthDate;
            this.genre = genre;
        }

        public void move()
        {

        }
        
        public void communicate()
        {

        }
        public void feed(string typeFood)
        {
 
        }

        public bool carnivorous(string typeFood)
        {
            if (typeFood == "carne")
            {
                return true;
            }
            return false;
        }

        public bool venomous(string havePoison)
        {
            if (havePoison == "yes")
            {
                return true;
            }
            return false;
        }
    }
}
