using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes_Abstratas.Models
{
    public class Motorola : Smartphone
    {
        public Motorola(string numero, string modelo, long imei, int memoria) : base (numero, modelo, imei, memoria) 
        {

        }

        public override void instalarApp()
        {
            string? nomeLoja = "";
            string mensagem = $"Instalando da loja {nomeLoja}";
            Console.Write("Por favor, digite o nome da sua loja de Aplicativos: ");
            nomeLoja = Console.ReadLine();

            string? nomeApp = "";
            Console.Write("Por favor, digite o nome do Aplicativo que quer instalar: ");
            nomeApp = Console.ReadLine();

            Console.WriteLine($"\nInstalando {nomeApp} da {nomeLoja}\n");
        }

    }
}
