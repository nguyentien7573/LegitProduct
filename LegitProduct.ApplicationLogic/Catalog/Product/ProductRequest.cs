using LegitProduct.ApplicationLogic.Common;
using LegitProduct.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Product
{
    public class GetPublicProductPaging : PagingRequest, IObjectRequest
    {
        public int? CategoryId { get; set; }
    }
    public class ProductCreateRequest: IObjectRequest
    {
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Description { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        public AppUser User { get; set; }

    }
    public class ProductPagingRequest : PagingRequest, IObjectRequest
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }

    public class ProductUpdateRequest : IObjectRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Description { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        public AppUser User { get; set; }
    }

    public class ProductViewModel : IObjectRequest
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Description { get; set; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public List<ProductCategory> Product_Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Data.Entities.ProductImage> ProductImages { get; set; }
        public AppUser AppUser { get; set; }
    }

}
