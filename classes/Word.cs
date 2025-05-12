using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EnglishHelperApp.classes
{
    internal class Word
    {
        private string TagName { get; set; }
        private bool Countable { get; set; }
        private List<Definition> Definitions { get; set; } = new List<Definition>();

        public Word() { }

        public Word(string tagName, bool countable)
        {
            TagName = tagName;
            Countable = countable;
        }

        public void AddDefinition(Definition definition)
        {
            Definitions.Add(definition);
        }

        public void SetTagName(string tagName)
        {
            TagName = tagName;
        }

        public string GetTagName()
        {
            return TagName;
        }

        public void SetCountability(bool countable)
        {
            Countable = countable;
        }

        public bool IsCountable()
        {
            return Countable;
        }

    }
}
