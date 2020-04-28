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
    public class CategoryService : ObjectService<Entities.Category>, ICategoryService
    {
        public CategoryService(LegitProductDBContext context) : base(context)
        { 
          
        }
    }
}
