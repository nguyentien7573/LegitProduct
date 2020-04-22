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
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Http;
using LegitProduct.ApplicationLogic.ProductImage;

namespace LegitProduct.ApplicationLogic.Catalog.Product
{
    public class ProductService : IProductService
    {
        private readonly LegitProductDBContext context;
        private readonly IStorageService _storageService;

        public ProductService(LegitProductDBContext context, IStorageService storageService)
        {
            this.context = context;
            _storageService = storageService;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFile(file.OpenReadStream(), fileName);
            return fileName;
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

            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<Entites.ProductImage>()
                {
                    new Entites.ProductImage()
                    {
                        DateCreated = DateTime.Now,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                    }
                };
            }

            context.Add(product);
            return await context.SaveChangesAsync();
        }
        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await context.Products.FindAsync(request.Id);

            if (product == null) throw new LegitProductException($"Sản phẩm {request.Id} không tồn tại");

            product.Name = request.Name;
            product.Price = request.Price;
            product.Description = request.Description;

            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await context.ProductImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    context.ProductImages.Update(thumbnailImage);
                }
            }

            return await context.SaveChangesAsync();
        }
        public async Task<int> Delete(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null) throw new LegitProductException($"Sản phẩm {id} không tồn tại");

            var images = context.ProductImages.Where(i => i.ProductId == id);
            foreach (var image in images)
            {
                await _storageService.DeleteFile(image.ImagePath);
            }

            context.Products.Remove(product);
            return await context.SaveChangesAsync();
        }

        public async Task<PageResult<ProductViewModel>> Get(GetPublicProductPaging request)
        {

            if (request.CategoryId.HasValue && request.CategoryId.Value <= 0)
            {
                throw new LegitProductException($"Loại sản phẩm không tồn tại");
            }

            var query = from p in context.Products
                        join pc in context.ProductInCategories on p.Id equals pc.ProductId
                        join ca in context.Categories on pc.CategoryId equals ca.Id
                        select new { p,pc };

            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(x=>x.pc.CategoryId == request.CategoryId.Value);
            }

            int totalRow = await query.CountAsync();
           
            var data = query.Skip((request.Index -1) * request.Size).Take(request.Size)
                .Select(x=>new ProductViewModel()
                {
                    Id = x.p.Id,
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

            return new PageResult<ProductViewModel>
            {
                TotalRecord = totalRow,
                Items = data.Result,
            };
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

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            var productImage = new Entites.ProductImage()
            {
                DateCreated = DateTime.Now,
                IsDefault = request.IsDefault,
                ProductId = productId,
            };

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await SaveFile(request.ImageFile);
            }
            context.ProductImages.Add(productImage);
            await context.SaveChangesAsync();
            return productImage.Id;
        }

        public Task<int> RemoveImage(int imageId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            var productImage = await context.ProductImages.FindAsync(imageId);
            if (productImage == null)
                throw new LegitProductException($"Không thể tìm hình với mã số {imageId}");

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await SaveFile(request.ImageFile);
            }
            context.ProductImages.Update(productImage);
            return await context.SaveChangesAsync();
        }

        public async Task<ProductImageViewModel> GetImageById(int imageId)
        {
            var image = await context.ProductImages.FindAsync(imageId);
            if (image == null)
                throw new LegitProductException($"Không thể tìm thấy hình ảnh với mã {imageId}");

            var viewModel = new ProductImageViewModel()
            {
                DateCreated = image.DateCreated,
                Id = image.Id,
                ImagePath = image.ImagePath,
                IsDefault = image.IsDefault,
                ProductId = image.ProductId,
            };
            return viewModel;
        }

        public async Task<PageResult<ProductImageViewModel>> GetListImages(int productId)
        {
            if (productId <= 0 )
            {
                throw new LegitProductException($"Không tìm thấy sản phẩm");
            }
            var data = await context.ProductImages.Where(x => x.ProductId == productId)
                 .Select(x => new ProductImageViewModel()
                 {
                     DateCreated = x.DateCreated,
                     Id = x.Id,
                     ImagePath = x.ImagePath,
                     IsDefault = x.IsDefault,
                     ProductId = x.ProductId,
                 }).ToListAsync();
            int totalRow = data.Count;

            return new PageResult<ProductImageViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
        }
    }
}
