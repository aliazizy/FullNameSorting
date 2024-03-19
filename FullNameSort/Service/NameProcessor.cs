using System.Xml.Linq;

namespace FullNameSort.Service
{
    public class NameProcessor
    {
        private readonly INameReaderService _nameReader;
        private readonly INameSorterService _nameSorter;
        private readonly INameWriterService _nameWriter;

        public NameProcessor(INameReaderService nameReader, INameSorterService nameSorter, INameWriterService nameWriter)
        {
            _nameReader = nameReader;
            _nameSorter = nameSorter;
            _nameWriter = nameWriter;
        }

        public string ProcessNames(string inputFilePath, string outputFilePath)
        {
            List<string> names = _nameReader.ReadNames(inputFilePath);
            List<string> sortedNames = _nameSorter.SortNames(names);
            _nameWriter.WriteNames(sortedNames, outputFilePath);
            return string.Join("\n", sortedNames);
        }
    }

}
