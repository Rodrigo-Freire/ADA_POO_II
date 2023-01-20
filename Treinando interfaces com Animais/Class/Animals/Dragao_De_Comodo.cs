using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class DragaoDeComodo : Reptile, IOvipro
    {
        public DragaoDeComodo(string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
        {
        }

        public void Hatch()
        {
            Console.WriteLine($"O {Name} incuba os ovos de 8 a 9 meses.");
        }

        public void Lay()
        {
            Console.WriteLine($"O {Name} consgue botar até 26 ovos.");
        }
    }
}
