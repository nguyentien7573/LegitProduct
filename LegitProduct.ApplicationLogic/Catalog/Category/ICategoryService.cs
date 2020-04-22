using LegitProduct.ApplicationLogic.Catalog.Category.Dtos;
using LegitProduct.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegitProduct.ApplicationLogic.Catalog.Category
{
    public interface ICategoryService
    {
        Task<CategoryViewModel> GetByID(int id);
        Task<PageResult<CategoryViewModel>> GetByParentID(int parentId);
        Task<PageResult<CategoryViewModel>> GetPaging(CategoryPagingRequest request);
        Task<int> Create(CategoryCreateRequest request);
        Task<int> Update(CategoryUpdateRequest request);
        Task<int> Delete(int id);
       
    }
}
