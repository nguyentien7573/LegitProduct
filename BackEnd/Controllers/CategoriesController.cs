using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LegitProduct.Data.EF;
using LegitProduct.Data.Entities;
using LegitProduct.ApplicationLogic.Catalog.Category;
using LegitProduct.ApplicationLogic.Common;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByID(int id)
        {
            var category = await _categoryService.GetByID(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        //[HttpGet]
        //public async Task<PageResult<CategoryViewModel>> GetPaging([FromQuery]CategoryPagingRequest request)
        //{
        //    return await _categoryService.GetPaging(request);
        //}

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromForm]CategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _categoryService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Create([FromForm]CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var categoryId = await _categoryService.Create(request);
            if (categoryId == 0)
                return BadRequest();

            var category = await _categoryService.GetByID(categoryId);

            return CreatedAtAction(nameof(GetByID), new { id = categoryId }, category);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _categoryService.Delete(id);
            if (result == 0)
                return BadRequest();

            return Ok();
        }
      
    }
}
