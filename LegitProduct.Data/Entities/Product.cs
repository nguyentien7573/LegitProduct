using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Product
    {
        public Product()
        {
            Attributes = new HashSet<Attribute>();
            CollectionProducts = new HashSet<CollectionProduct>();
            Favorites = new HashSet<Favorite>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductBranches = new HashSet<ProductBranch>();
            ProductCategories = new HashSet<ProductCategory>();
            ProductImages = new HashSet<ProductImage>();
            ProductPrices = new HashSet<ProductPrice>();
            PromotionProducts = new HashSet<PromotionProduct>();
            Rates = new HashSet<Rate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? AppUserId { get; set; }
        public int? StoreId { get; set; }
        public int Status { get; set; }
        public int IsApprove { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedUserId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<CollectionProduct> CollectionProducts { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductBranch> ProductBranches { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
    }
}
