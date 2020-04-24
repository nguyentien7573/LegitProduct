using LegitProduct.ApplicationLogic.Catalog.Category.Dtos;
using LegitProduct.ApplicationLogic.Common;
using Entities = LegitProduct.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LegitProduct.Data.EF;
using Utilities.Exceptions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LegitProduct.Data.ObjectEnums;

namespace LegitProduct.ApplicationLogic.Catalog.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly LegitProductDBContext context;

        public CategoryService(LegitProductDBContext context)
        {
            this.context = context;
        }

        public async Task<int> Create(CategoryCreateRequest request)
        {
            var category = new Entities.Category()
            {
                Name = request.Name,
                Status = (int)request.Status,
                ParentId = request.ParentId
            };

            context.Categories.Add(category);

            return await context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            var category = context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null)
            {
                throw new LegitProductException($"Loại sản phẩm {id} không tồn tại");
            }

            context.Categories.Remove(category);

            return await context.SaveChangesAsync();
        }

        public async Task<CategoryViewModel> GetByID(int id)
        {
            var category = await context.Categories.FindAsync(id);

            if (category == null)
            {
                throw new LegitProductException($"Loại sản phẩm {id} không tồn tại");
            }

            var categoryViewModel = new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
                Status = (Status)category.Status
            };

            return categoryViewModel;
        }

        public async Task<PageResult<CategoryViewModel>> GetByParentID(int parentId)
        {
            var category = context.Categories.Where(x => x.ParentId == parentId);

            if (category == null)
            {
                throw new LegitProductException($"Loại sản phẩm {parentId} không tồn tại");
            }

            int totalRow = await category.CountAsync();

            var data = await category.Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Status = (Status)x.Status,
                ParentId = x.ParentId
            }).ToListAsync();

            var PageResult = new PageResult<CategoryViewModel>()
            {
                Items = data,
                TotalRecord = totalRow
            };

            return PageResult;
        }

        public async Task<PageResult<CategoryViewModel>> GetPaging(CategoryPagingRequest request)
        {
            var category = await context.Categories.ToListAsync();

            if (request.ParentId.HasValue && request.ParentId.Value >0)
            {
                category =  category.Where(x => x.ParentId == request.ParentId.Value).ToList();
            }
            else
            {
                throw new LegitProductException($"Chưa có loại sản phẩm nào");
            }

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                category = category.Where(x => x.Name.ToLower().Contains(request.Keyword.ToLower())).ToList();
            }

            int totalRow = category.Count;

            var data = category.Skip((request.Index - 1) * request.Size).Take(request.Size).Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                ParentId = x.ParentId,
                Status = (Status)x.Status
            }).ToList() ;

            var PageResult = new PageResult<CategoryViewModel>()
            {
                Items = data,
                TotalRecord = totalRow
            };

            return PageResult;
        }

        public async Task<int> Update(CategoryUpdateRequest request)
        {
            var category = await context.Categories.FindAsync(request.Id);

            if (category == null) throw new LegitProductException($"Loại sản phẩm {request.Id} không tồn tại");

            category.Name = request.Name;
            category.ParentId = request.ParentId;
            category.Status = (int)request.Status;
         
            context.Categories.Update(category);

            return await context.SaveChangesAsync();
        }
    }
}
