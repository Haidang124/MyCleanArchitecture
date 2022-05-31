namespace MyCleanArchitecture.DomainShare.Objects
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}