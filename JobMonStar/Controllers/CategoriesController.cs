using AutoMapper;
using JobMonStar.Data;
using JobMonStar.Models;
using JobMonStar.Respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobMonStar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _catecontext;

        public CategoriesController(ICategoryRepository a ) {
            _catecontext = a;
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> AddCategory(CategoryDTO newCharacter)
        {
            return Ok(await _catecontext.AddCategoryAsync(newCharacter));
        }
        [HttpGet]
        public async Task<ActionResult<List<CategoryDTO>>> GetallCategory()
            
        {
            await _catecontext.GetAllCategoriesAsync();
            return Ok(await _catecontext.GetAllCategoriesAsync());
        }
        [HttpDelete("id")]

        public async Task<ActionResult<CategoryDTO>> DeleteCategory(int id)
        {
            return Ok(await _catecontext.DeletCategoryAsync(id));
        }

        [HttpPut]
        public async Task<ActionResult<CategoryDTO>> UpdateCategory(CategoryDTO categoryDTO)
        {
            await _catecontext.UpdateCategoryAsync(categoryDTO);
            return Ok(categoryDTO);
        }

    }
}
