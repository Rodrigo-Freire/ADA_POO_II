using Classes_Abstratas.Models;

namespace Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorola celular = new Motorola("984984889", "A52s", 123456789123456, 8);

            Console.WriteLine($"Número celular: {celular.numero} " +
                $"\nModelo: {celular.modelo}" +
                $"\nIMEI: {celular.imei}" +
                $"\nMemória de {celular.memoria}Gb ");
            Console.WriteLine("\nAgora vamos instalar um aplicativo!\n");
            

            celular.instalarApp();
        }
    }
}