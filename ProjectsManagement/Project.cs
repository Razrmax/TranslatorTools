using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.Office.Interop.Word;
using Document = Microsoft.Office.Interop.Word.Document;

namespace ProjectsManagement
{
    public enum LanguagePair
    {
        EnglishRussian,
        RussianEnglish,
        GermanRussian,
        RussianGerman
    }

    class Project
    {

        public Customer Customer { get; set; }
        public Dictionary<Document, Document> TranslationDocuments { get; set; }
        public Dictionary<string, string> TranslationMemory { get; set; }
        
    }
}
