using FullNameSort.Service.Tests.Stubs;

namespace FullNameSort.Service.Tests
{
    [TestClass()]
    public class NameProcessorTests
    {

        [TestMethod()]
        public void ItShouldSortListOfNames()
        {
            var nameSorter = new NameSorterService();
            
            List<string> sortedNames = nameSorter.SortNames(StubNames.OriginalUnsortedNames);
            Assert.AreEqual(string.Join(",",sortedNames), string.Join(",", StubNames.OriginalSortedNames));
        }
        [TestMethod()]
        public void ItShouldSortListOfNamesAndRemoveEmptyValues()
        {
            var nameSorter = new NameSorterService();

            List<string> sortedNames = nameSorter.SortNames(StubNames.UnsortedNamesWithEmptyName);
            Assert.AreEqual(string.Join(",", sortedNames), string.Join(",", StubNames.SortedNamesWithEmptyName));
        }
        [TestMethod()]
        public void ItShouldSortListOfNamesAndRemoveNamesWithoutGivenName()
        {
            var nameSorter = new NameSorterService();

            List<string> sortedNames = nameSorter.SortNames(StubNames.UnsortedNamesWithMissingGivenName);
            Assert.AreEqual(string.Join(",", sortedNames), string.Join(",", StubNames.SortedNamesWithMissingGivenName));
        }
        [TestMethod()]
        public void ItShouldnotFailOnEmptyListAndReturn()
        {
            var nameSorter = new NameSorterService();

            List<string> sortedNames = nameSorter.SortNames(StubNames.EmptyList);
            Assert.AreEqual(sortedNames.Count,0);
        }
    }
}