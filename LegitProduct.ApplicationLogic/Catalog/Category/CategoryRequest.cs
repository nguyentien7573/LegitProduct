using LegitProduct.ApplicationLogic.Common;
using LegitProduct.Data.ObjectEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Category
{
    public class CategoryCreateRequest : IObjectRequest
    {
        public string Name { get; set; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }

    public class CategoryUpdateRequest : IObjectRequest
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }

    public class CategoryViewModel : IObjectRequest
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }

    public class CategoryPagingRequest : PagingRequest, IObjectRequest
    {
        public string Keyword { get; set; }
        public int? ParentId { get; set; }
    }
}
