using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Jacare : Reptile, IOvipro, Aquatic
    {
        public Jacare(string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
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

        public void Hatch()
        {
            Console.WriteLine($"O {Name} incuba os ovos de 65 a 90 dias.");
        }

        public void Lay()
        {
            Console.WriteLine($"O {Name} consgue botar até 30 ovos.");
        }

        public bool LiveOnLand()
        {
            return false;
        }
    }
}
