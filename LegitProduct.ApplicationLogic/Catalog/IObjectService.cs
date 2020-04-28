using LegitProduct.ApplicationLogic.Catalog.Product.Dtos;
using LegitProduct.ApplicationLogic.Common;
using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LegitProduct.ApplicationLogic.Catalog
{
    public interface IObjectService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
        Task<int> Create(IObjectRequest entityRequest);
        Task<int> Update(IObjectRequest entityRequest);
        Task<int> Delete(int id);
    }
}
