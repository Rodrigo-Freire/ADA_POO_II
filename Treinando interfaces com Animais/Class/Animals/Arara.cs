using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Arara : Bird, IFly, IOvipro
    {
        public Arara(string name, DateTime birthDate, char genre, int age) : base(name, birthDate, genre, age)
        {
        }

        public string maximumAltitude
        {
            get { return "98 pés"; }
            set { maximumAltitude= value; }
        }
        public double flightSpeed
        {
            get { return 56; }
            set { flightSpeed = value; }
        }

        public void Flying()
        {
            Console.WriteLine($"A {Name} consegue voar a uma altitude de {maximumAltitude} a uma velocidade de {flightSpeed}Km/h");
        }

        public void Hatch()
        {
            Console.WriteLine($"A {Name} choca os ovos por 27 a 30 dias.");
        }

        public void Lay()
        {
            Console.WriteLine($"A {Name} consgue botar até 3 ovos.");
        }
    }
}
