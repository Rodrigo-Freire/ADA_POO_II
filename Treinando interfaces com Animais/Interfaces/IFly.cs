using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Interfaces
{
    public interface IFly
    {
        public string maximumAltitude { get; set; }
        public double flightSpeed { get; set; }
        public void Flying();
    }
}
