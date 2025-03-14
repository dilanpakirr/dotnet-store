namespace dotnet_store.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        public string Url { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}