namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parte 01
            Student student = new Student();
            DisplayPublicProperties(typeof(Student));

            //parte 02
            var student2 = (Student)CreateInstance(typeof(Student));
            student2.Name = "Rodrigo Freire";
            student2.University = "Let's Code - Ada";
            student2.RollNumber = 1;

            var propertiesValues = new Dictionary<string, object>
            {
                {"Name", student2.Name },
                {"University", student2.University},
                {"RollNumber", student2.RollNumber }

            };
              
            fillProperties(student2, propertiesValues);
        }

        #region 1
        public static void DisplayPublicProperties(Type type)
        {
            var properties = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }
        #endregion
        #region 2

        public static object CreateInstance(Type type) 
        {
            return Activator.CreateInstance(type);
        }
        public static void fillProperties(object student2, Dictionary<string, object> propertiesValues)
        {
            var type = student2.GetType();
            var properties = type.GetProperties(System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.Instance);

            foreach(var property in properties)
            {
                if (propertiesValues.ContainsKey(property.Name))
                {
                    property.SetValue(student2, propertiesValues[property.Name]);
                }
            }
        }

        #endregion
    }
}