﻿namespace WebApp_Nest_04122024.Models
{
    public class TagProduct
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public Tag Tags { get; set; }
        public int ProductId {  get; set; }
        public Product Product { get; set; }
    }
}
