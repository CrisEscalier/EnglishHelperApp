using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishHelperApp.classes
{
    internal class Dictionary
    {
        private string TagName { get; set; }

        private List<Word> Words { get; set; } = new List<Word>();

        public Dictionary() { }

        public List<Word> GetDictionary()
        {
            return Words;
        }

        public void AddWord(Word word)
        {
            Words.Add(word);
        }

        public bool IsEmtpy()
        {
            return Words.Count == 0;
        }

    }
}
