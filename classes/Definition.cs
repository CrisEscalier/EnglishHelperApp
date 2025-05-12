using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishHelperApp.classes
{
    internal class Definition
    {
        private string Pronunciation { get; set; }
        private string WordDefinition { get; set; }
        private string WordType { get; set; }
        private bool IsWeakForm { get; set; }

        public Definition() { }

        public Definition(string pronunciation, string wordDefinition, string wordType, bool isWeakForm)
        {
            Pronunciation = pronunciation;
            WordDefinition = wordDefinition;
            WordType = wordType;
            IsWeakForm = isWeakForm;
        }

        public void SetPronunciation(string pronunciation)
        {
            Pronunciation = pronunciation;
        }

        public string GetPronunciation()
        {
            return Pronunciation;
        }

        public void SetDefinition(string definition)
        {
            WordDefinition = definition;
        }

        public string GetDefinition()
        {
            return WordDefinition;
        }

        public void SetWordType(string type)
        {
            WordType = type;
        }

        public string GetWordType()
        {
            return WordType;
        }

        public void SetForm(bool weakForm)
        {
            IsWeakForm = weakForm;
        }

        public bool HasWeakForm()
        {
            return IsWeakForm;
        }


    }
}
