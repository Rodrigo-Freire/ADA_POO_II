using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public Smartphone(string numero, string modelo, long imei, int memoria)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
            Console.Clear();
        }

        public void Ligar(int numerodiscado)
        {
            int chamando = 0;
            while (chamando == 0)
            {

                Console.Write("Por favor, digite o número para qual deseja ligar: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out numerodiscado))
                {
                    if (input.Length < 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Número inválido! Digite um número com pelo menos 8 digitos");
                    }
                    else
                    {
                        Console.WriteLine($"Chamando... {numerodiscado}");
                        chamando = 1;
                        Console.Write("\nChamada finalizada. " +
                            "\nPressione qualquer tecla para continuar.\n");
                        Console.ReadKey();
                        

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Número inválido! Digite apenas números");

                }
            }
        }

        public void recebeLigacao()
        {
            Console.Clear();
            Random r = new Random();
            List<int> listaDdd = new List<int>() { 11,  12,     13,     14,     15,     16,     17,     18,     19,     21,     22,     24,     27,
                28,     31,     32,     33,     34,     35,     37,     38,     41,     42,     43,     44,     45,     46,     47,     48,     49,
                51,     53,     54,     55,     61,     62,     63,     64,     65,     66,     67,     68,     69,     71,     73,     74,     75,
                77,     79,     81,     82,     83,     84,     85,     86,     87,     88,     89,     91,     92,     93,     94,     95,     96,
                97,     98,     99,};

            int ddd = listaDdd[r.Next(listaDdd.Count)];      
            int num2 = r.Next( 2000, 9999 );
            int num3 = r.Next(2000, 9999);

            Console.WriteLine($"Recebendo ligação... ({ddd}) 9{num2}-{num3} ");
            Console.Write("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public virtual void instalarApp()
        {
            string? nomeApp = "";
            Console.Write("Por favor, digite o nome do Aplicativo que quer instalar: ");
            nomeApp = Console.ReadLine();

            
        }

    }
}
