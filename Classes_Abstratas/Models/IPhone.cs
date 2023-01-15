using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas.Models
{
    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo, long imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine("Bem-vindo a Loja Oficial da Apple! " +
                "\n\nEsses são seus dados cadastrados:\n");
        }

        public override void instalarApp()
        {
            string? nomeLoja = "Apple Store";
            string? nomeApp = "";
            Console.Write("Por favor, digite o nome do Aplicativo que quer instalar: ");
            nomeApp = Console.ReadLine();
            nomeApp.ToUpper();

            Console.WriteLine($"\nInstalando {nomeApp} da {nomeLoja}\n");
            Console.Write("Instalação 100% Concluída. Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
