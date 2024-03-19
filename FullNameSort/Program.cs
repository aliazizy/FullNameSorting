using FullNameSort.Service;
using FullNameSort;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputFilePath = "./unsorted-names-list.txt";

        var outputFilePath = "./sorted-names-list.txt";
        INameReaderService nameReader = new TextFileReaderService();
        INameSorterService nameSorter = new NameSorterService();
        INameWriterService nameWriter = new TextFileWriterService();

        var processor = new NameProcessor(nameReader, nameSorter, nameWriter);
        var sortedNames = processor.ProcessNames(inputFilePath, outputFilePath);
        Console.WriteLine(sortedNames);
        Console.WriteLine("\nNames sorted and written to output file.Press enter to exit.");
        Console.ReadLine();
    }
}