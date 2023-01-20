using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Lontra : Mammal, Aquatic
    {
        public Lontra(string name, DateTime birthDate, char genre, int age, int qtyBoobs) : base(name, birthDate, genre, age, qtyBoobs)
        {
        }

        public bool Dips()
        {
            return true;
        }

        public bool Freshwater()
        {
            return true;
        }

        public bool LiveOnLand()
        {
            return false;
        }
    }
}
