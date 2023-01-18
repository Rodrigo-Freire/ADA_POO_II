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

        public void Move()
        {

        }
        
        public void Communicate()
        {

        }
        public void Feed(string typeFood)
        {
 
        }

        public bool Carnivorous(string typeFood)
        {
            if (typeFood == "carne")
            {
                return true;
            }
            return false;
        }

        public bool Venomous(string havePoison)
        {
            if (havePoison == "yes")
            {
                return true;
            }
            return false;
        }
    }
}
