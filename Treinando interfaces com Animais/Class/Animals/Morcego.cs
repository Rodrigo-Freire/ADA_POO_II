using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Class.Animals
{
    public class Morcego : Mammal, IFly 
    {
        

    public Morcego(string name, DateTime birthDate, char genre, int age, int qtyBoobs) : base(name, birthDate, genre, age, qtyBoobs)
        {

        }

        
        public string maximumAltitude
        {
            get { return "10 Metros"; }
            set { maximumAltitude = value; }
        }
        public double flightSpeed 
        { 
            get { return 5; }
            set { flightSpeed = value; } 
        }


        public void Flying()
        {
            Console.WriteLine($"Eu consigo voar há uma altitude de {maximumAltitude} a uma velocidade de {flightSpeed}km");
        }
    }

}
