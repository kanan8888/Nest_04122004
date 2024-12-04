namespace WebApp_Nest_04122024.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float? OldPrice { get; set; }
        public string ImageUrl { get; set; }
        public List<TagProduct> TagProducts { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
