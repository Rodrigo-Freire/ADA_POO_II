using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Ornitorrinco : Mammal, IOvipro, Aquatic
    {
        public Ornitorrinco(string name, DateTime birthDate, char genre, int age, int qtyBoobs) : base(name, birthDate, genre, age, qtyBoobs)
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
            Console.WriteLine($"O {Name} incuba os ovos de 10 a 14 dias.");
        }

        public void Lay()
        {
            Console.WriteLine($"O {Name} consgue botar até 3 ovos.");
        }

        public bool LiveOnLand()
        {
            return false;
        }
    }
}
