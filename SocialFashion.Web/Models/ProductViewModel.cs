using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialFashion.Web.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int ProductTypeID { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> PromotionPrice { get; set; }
        public Nullable<int> Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public Nullable<int> ViewCount { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
    }
}