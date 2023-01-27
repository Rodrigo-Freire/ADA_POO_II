namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary= new Dictionary();
            dictionary.AddTerm("Manga", "Fruta");

            dictionary.SaveToFile();
            dictionary.LoadFromFile();
            dictionary.SearchTerm("Manga");
        }
    }
}