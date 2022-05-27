namespace MyCleanArchitecture.DomainShare
{
    public class PagedAndSortedResult<T>
    {
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}