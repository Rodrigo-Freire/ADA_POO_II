using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Dictionary
    {

        private Dictionary<string, string> terms = new Dictionary<string, string>();
        private string fileName = "terms.txt";

        public void AddTerm(string term, string meaning)
        {
            // Adicionando termo ao dicionário
            terms.Add(term.ToLower(), meaning);
        }

        public void SearchTerm(string term)
        {
            // Buscando termo no dicionário, ignorando maiúsculas e minúsculas
            var matchingTerms = terms.Where(t => t.Key.Contains(term.ToLower()));

            if (matchingTerms.Count() == 0)
            {
                Console.WriteLine("Nenhum termo encontrado");
            }
            else
            {
                foreach (var match in matchingTerms)
                {
                    Console.WriteLine("{0}: {1}", match.Key, match.Value);
                }
            }
        }

        public void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var term in terms)
                {
                    writer.WriteLine("{0}:{1}", term.Key, term.Value);
                }
            }
        }

        public void LoadFromFile()
        {
            if (!File.Exists(fileName))
            {
                return;
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string term = parts[0];
                    string meaning = parts[1];
                    terms.Add(term, meaning);
                }
            }
        }
    }

}

