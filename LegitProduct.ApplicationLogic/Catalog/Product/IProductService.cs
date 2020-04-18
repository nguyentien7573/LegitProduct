using LegitProduct.ApplicationLogic.Catalog.Product.Dtos;
using LegitProduct.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegitProduct.ApplicationLogic.Catalog.Product
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int id);
        Task<ProductViewModel> GetByID(int productID);
        Task<PageResult<ProductViewModel>> GetProductPaging(ProductPagingRequest request);
    }
}
