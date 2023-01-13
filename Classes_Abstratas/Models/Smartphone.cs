using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; }
        public string modelo { get; set; }
        public long imei { get; set; }
        public int memoria { get; set; }

        public void Ligar(long numerodiscado)
        {
            Console.WriteLine($"Chamando... {numerodiscado}");
        }

        public void recebeLigacao()
        {
            Random r = new Random();
            int ddd = r.Next(11, 99);      
            int num2 = r.Next( 2000, 9999 );
            int num3 = r.Next(2000, 9999);

            Console.WriteLine($"Recebendo ligação... ({ddd}) 9{num2}-{num3} ");
        }

        public virtual string instalarApp(string nomeLoja)
        {
            return "Acessando " + nomeLoja;
        }

    }
}
