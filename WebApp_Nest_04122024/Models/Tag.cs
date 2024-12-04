namespace WebApp_Nest_04122024.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public List<TagProduct> TagProducts {  get; set; }
        
    }
}
