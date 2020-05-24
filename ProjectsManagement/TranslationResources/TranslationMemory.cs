using System.Collections.Generic;
using System.Linq;
using ProjectsManagement.model;

namespace ProjectsManagement.TranslationResources
{
    public class TranslationMemory
    {
        public Dictionary<string, string> WordBook { get; set; }
        public LanguagePair LanguagePair { get; set; }
        public int Count { get; set; }

        public TranslationMemory(LanguagePair languagePair)
        {
            LanguagePair = languagePair;
            WordBook = new Dictionary<string, string>();
        }

        public TranslationMemory(LanguagePair languagePair, Dictionary<string, string> wordBook)
        {
            LanguagePair = languagePair;
            WordBook = wordBook;
        }

        public TranslationMemory()
        {
            WordBook = new Dictionary<string, string>();
        }

        public void Add(string source, string target)
        {
            WordBook.Add(source, target);
        }

        public void Remove(string source)
        {
            WordBook.Remove(source);
        }

        public string LookupBySource(string source)
        {
            return WordBook.ContainsKey(source) ? WordBook[source] : null;
        }

        public string LookupByTarget(string target)
        {
            return WordBook.ContainsValue(target)
                ? WordBook.FirstOrDefault(entry => entry.Value == target).Key
                : null;
        }

        public void UpdateByTarget(string source, string target)
        {
            WordBook[source] = target;
        }
    }
}
