using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Lion : Mammal
    {
        public Lion(string name, DateTime birthDate, char genre, int age, int qtyBoobs) : base(name, birthDate, genre, age, qtyBoobs) 
        {
            this.age = age;
            this.birthDate = birthDate; 
            this.genre = genre;
            this.Name= name;
            this.qtyBoobs = qtyBoobs;
        }
    }
}
