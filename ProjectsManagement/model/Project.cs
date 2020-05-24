using System;
using System.Collections.Generic;
using ProjectsManagement.TranslationResources;
using ProjectsManagement.Person;
using Document = Microsoft.Office.Interop.Word.Document;


namespace ProjectsManagement.model
{
    public enum LanguagePair
    {
        EnglishRussian,
        RussianEnglish,
        GermanRussian,
        RussianGerman
    }
    /// <summary>
    /// Central class around which the whole business logic is built. Contains classes:
    /// - Customer
    /// - TranslationDocuments for the project documents,
    /// - TranslationMemory for a project translation memory,
    /// - TermBase for a project specific vocabulary.
    /// </summary>
    class Project
    {
        public Customer Customer { get; private set; }
        public TranslationJob TranslationDocuments { get; private set; }
        public TranslationMemory TranslationMemory { get; private set; }
        public TermBase Vocabulary { get; private set; }
        public string Notes { get; private set; }
        public double RatePerPage { get; private set; }
        public double TotalPages { get; private set; }
        public DateTime StartDate { get; private set; }
        private bool workInProgress;
    }
}
