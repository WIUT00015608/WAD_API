using ContactManagerAPI.DAL.Repositories.CategoryRepository;
using ContactManagerAPI.DTO.Category;
using ContactManagerAPI.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagerAPI.Controllers
{
    //Student ID is 00015608
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepo = categoryRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryRepo.GetAllAsync();
            var categoryDto = categories.Select(s => s.ToCategoryDto());
            return Ok(categoryDto);
        }

        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var category = await _categoryRepo.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category.ToCategoryDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryDto categoryDto)
        {
            var model = categoryDto.ToCreateCategory();
            await _categoryRepo.CreateAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model.ToCategoryDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCategoryDto updateCategoryDto)
        {
            var model = await _categoryRepo.UpdateAsync(id, updateCategoryDto);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model.ToCategoryDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var model = await _categoryRepo.DeleteAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
