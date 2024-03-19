namespace FullNameSort.Service
{
    public class TextFileWriterService : INameWriterService
    {
        public void WriteNames(List<string> sortedNames, string filePath)
        {
            File.WriteAllLines(filePath, sortedNames);
        }
    }

}
