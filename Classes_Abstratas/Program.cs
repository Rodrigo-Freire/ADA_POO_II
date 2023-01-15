using Classes_Abstratas.Models;

namespace Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorola celular = new Motorola("(79) 98715-7757", "Motorola Edge 30 Ultra", 359517094214293, 12);

            Console.WriteLine($"Número do Celular - {celular.numero} " +
                $"\nModelo - {celular.modelo}" +
                $"\nIMEI - {celular.imei}" +
                $"\nMemória de {celular.memoria}Gb ");
            Console.WriteLine("\nAgora vamos instalar um aplicativo!\n");        

            celular.instalarApp();
            celular.recebeLigacao();

            Console.WriteLine();

            IPhone iphone14 = new IPhone("(67) 98791-7760", "iPhone 14 Pro Max", 356728113056648, 6);
            Console.WriteLine($"Número do Celular - {iphone14.numero} " +
                            $"\nModelo - {iphone14.modelo}" +
                            $"\nIMEI - {iphone14.imei}" +
                            $"\nMemória de {iphone14.memoria}Gb ");
            Console.WriteLine("\nAgora vamos instalar um aplicativo!\n");

            iphone14.instalarApp();
            iphone14.recebeLigacao();

            Console.Clear();
            Console.WriteLine("Fim do Programa. Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}