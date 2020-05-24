using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Microsoft.Office.Interop.Word;

namespace ProjectsManagement.TranslationResources
{
    class TranslationJob
    {
        public Dictionary<Document, Document> RawText { get; private set; }
        public int Counter { get; private set; }

        #region Constructors
        public TranslationJob(Dictionary<Document, Document> rawText)
        {
            RawText = rawText;
        }

        public TranslationJob()
        {
            RawText = new Dictionary<Document, Document>();
        } 
        #endregion

        #region General Methods
        public void Add(Document sourceText, Document targetText)
        {
            RawText.Add(sourceText, targetText);
            Counter++;
        }

        public void Remove(Document sourceText)
        {
            RawText.Remove(sourceText);
        }

        public bool RemoveTargetOnly(Document sourceText, Document targetText)
        {
            if (RawText[sourceText] == targetText)
            {
                Remove(sourceText);
                Add(sourceText, null);
                return true;
            }

            return false;
        } 
        #endregion
    }
}
