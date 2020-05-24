namespace ProjectsManagement.TranslationResources
{
    public class TermBase : TranslationMemory
    {
        public void UpdateBySource(string oldValue, string newValue)                             
        {
            WordBook[newValue] = WordBook[oldValue];
            Remove(oldValue);
        }
    }
}
