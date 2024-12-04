namespace WebApp_Nest_04122024.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<Product> Products { get; set; }
    }
}
