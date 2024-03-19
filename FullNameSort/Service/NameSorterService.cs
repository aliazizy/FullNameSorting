namespace FullNameSort.Service
{
    public class NameSorterService : INameSorterService
    {
        public List<string> SortNames(List<string> names)
        {
            //A name must have at least 1 given name and may have up to 3 given names. So removing those that are null or does not have atleast one given name
            for (int i = 0; i < names.Count; i++)
            {
                if (string.IsNullOrEmpty(names[i]) || names[i].Trim().Split(' ').Length < 2) names.RemoveAt(i);
            }
            return names.OrderBy(name => PutLastNameFirst(name)).ToList();
        }

        private string PutLastNameFirst(string name)
        {
            var parts = name.Split(' ');
            var lastName = parts.Last();
            var givenNames = string.Join(" ", parts.Take(parts.Length - 1));
            return $"{lastName} {givenNames}";
        }
    }

}
