using LegitProduct.ApplicationLogic.Catalog.Product.Dtos;
using LegitProduct.ApplicationLogic.Common;
using LegitProduct.Data.EF;
using Entites = LegitProduct.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exceptions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LegitProduct.ApplicationLogic.Catalog.Product
{
    public class ProductService : IProductService
    {
        private readonly LegitProductDBContext context;

        public ProductService(LegitProductDBContext context)
        {
            this.context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Entites.Product()
            {
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                AppUser  = request.User,
            };
            context.Add(product);
            return await context.SaveChangesAsync();
        }
        public async Task<int> Delete(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null) throw new LegitProductException($"Sản phẩm {id} không tồn tại");

            context.Products.Remove(product);
            return await context.SaveChangesAsync();
        }
        public async Task<ProductViewModel> GetByID(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null) throw new LegitProductException($"Sản phẩm {id} không tồn tại");

            var productViewModel = new ProductViewModel()
            {
                AppUser = product.AppUser,
                Description = product.Description,
                DateCreated = product.DateCreated,
                Id = product.Id,
                Name = product.Name,
                OrderDetails = product.OrderDetails,
                Price = product.Price,
                ProductImages = product.ProductImages,
                Product_Category = product.Product_Category,
                ViewCount = product.ViewCount
            };
            return productViewModel;
        }
        public async Task<PageResult<ProductViewModel>> GetProductPaging(ProductPagingRequest request)
        {
            //Select
            var query = from p in context.Products
                        join pc in context.ProductInCategories on p.Id equals pc.ProductId
                        join c in context.Categories on pc.CategoryId equals c.Id
                        where p.Name.Contains(request.Keyword)
                        select new {p};

            //Filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.p.Name.Contains(request.Keyword));
            }

            //Paging
            int totalRow = await query.CountAsync();

            var data = query.Skip((request.Index - 1) * request.Size).Take(request.Size)
                .Select(x => new ProductViewModel()
                {
                    Id= x.p.Id,
                    Name = x.p.Name,
                    Price = x.p.Price,
                    Description = x.p.Description,
                    AppUser = x.p.AppUser,
                    OrderDetails = x.p.OrderDetails,
                    ProductImages = x.p.ProductImages,
                    DateCreated = x.p.DateCreated,
                    Product_Category = x.p.Product_Category,
                    ViewCount = x.p.ViewCount,
                }).ToListAsync();
            var pageResult = new PageResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data.Result
            };

            return pageResult;
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await context.Products.FindAsync(request.Id);

            if (product == null) throw new LegitProductException($"Sản phẩm {request.Id} không tồn tại");

            product.Name = request.Name;
            product.Price = request.Price;
            product.Description = request.Description;
            
            return await context.SaveChangesAsync();
        }
    }
}
