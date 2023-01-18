namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            DisplayPublicProperties(typeof(Student));
        }
        
        public static void DisplayPublicProperties(Type type)
        {
            var properties = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }
    }
}