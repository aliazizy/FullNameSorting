namespace FullNameSort.Service
{
    public class TextFileReaderService : INameReaderService
    {
        public List<string> ReadNames(string filePath)
        {
            return File.ReadAllLines(filePath).ToList();
        }
    }
}
