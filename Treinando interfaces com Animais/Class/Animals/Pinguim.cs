using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Pinguim : Bird, IOvipro, Aquatic
    {
        public Pinguim(string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
        {
        }

        public bool Dips()
        {
            return true;
        }

        public bool Freshwater()
        {
            return false;
        }

        public void Hatch()
        {
            Console.WriteLine($"O {Name} incuba os ovos de 33 a 35 dias.");
        }

        public void Lay()
        {
            Console.WriteLine($"O {Name} consgue botar até 2 ovos.");
        }

        public bool LiveOnLand()
        {
            return true;
        }
    }
}
