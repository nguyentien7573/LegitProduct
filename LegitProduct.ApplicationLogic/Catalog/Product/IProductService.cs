using LegitProduct.ApplicationLogic.Catalog.Product.Dtos;
using LegitProduct.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LegitProduct.ApplicationLogic.Catalog.ProductImage;
using LegitProduct.ApplicationLogic.Catalog.ProductImage.Dtos;

namespace LegitProduct.ApplicationLogic.Catalog.Product
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int id);
        Task<PageResult<ProductViewModel>> Get(GetPublicProductPaging request);
        Task<ProductViewModel> GetByID(int productID);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<PageResult<ProductImageViewModel>> GetListImages(int productId);
    }
}
