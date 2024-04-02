namespace OU.JwtApp.Back.Core.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
        public ICollection<Product> Products { get; set; }
       
    }
}
