using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Cisne : Bird, IFly, Aquatic, IOvipro
    {
        public Cisne(string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
        {

        }

        public string maximumAltitude 
            { get { return "10 pés"; }
              set { maximumAltitude = value; } 
            }
        public double flightSpeed
        {
            get { return 135; }
            set { flightSpeed = value; }
        }

        public bool Dips()
        {
            return false;
        }

        public void Flying()
        {
            Console.WriteLine($"O {Name} consegue voar a uma altitude de {maximumAltitude} a uma velocidade de {flightSpeed}Km/h");
        }

        public bool Freshwater()
        {
            return true;
        }

        public void Hatch()
        {
            Console.WriteLine($"O {Name} choca os ovos por 34 a 40 dias.");
        }

        public void Lay()
        {
            Console.WriteLine($"O {Name} consgue botar até 8 ovos.");
        }

        public bool LiveOnLand()
        {
            return false;
        }
    }
}
