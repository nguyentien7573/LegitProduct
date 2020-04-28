using LegitProduct.Data.EF;
using Microsoft.EntityFrameworkCore;
using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exceptions;

namespace LegitProduct.ApplicationLogic.Catalog
{
    public class ObjectService<T> : IObjectService<T> where T : class
    {
        private readonly LegitProductDBContext context;
        private DbSet<T> entities;

        public ObjectService(LegitProductDBContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public virtual async Task<T> GetByID(int id)
        {
            return await entities.FindAsync(id);
        }

        public virtual async Task<int> Create(IObjectRequest entityRequest)
        {
            var entity = Mapper.Map<T>(entityRequest);

            if (entity == null) throw new LegitProductException("Invalid object");
            entities.Add(entity);
            
            return await context.SaveChangesAsync();
        }

        public virtual async Task<int> Delete(int id)
        {
            if (id <= 0) throw new LegitProductException("Invalid object");

            T entity = await entities.FindAsync(id);
            entities.Remove(entity);
            return await context.SaveChangesAsync();
        }
        public virtual async Task<int> Update(IObjectRequest entityRequest)
        {
            var entity = Mapper.Map<T>(entityRequest);

            entities.Update(entity);
            return await context.SaveChangesAsync();
        }
    }
}
