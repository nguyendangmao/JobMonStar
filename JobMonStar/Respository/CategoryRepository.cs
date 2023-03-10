using AutoMapper;
using JobMonStar.Data;
using JobMonStar.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;

namespace JobMonStar.Respository
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly DBJobContext _context;
        private readonly IMapper _mapper;

        public CategoryRepository(DBJobContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> AddCategoryAsync(CategoryDTO model)
        {
            var addCategoryAsync =_mapper.Map<Category>(model);
            _context.Categories!.Add(addCategoryAsync);
            await   _context.SaveChangesAsync();

            return model;
        }
        public async Task<CategoryDTO> UpdateCategoryAsync( CategoryDTO model)
        {
            
                var updateCategoryAsync = _mapper.Map<Category>(model);
                _context.Categories!.Update(updateCategoryAsync);
                await _context.SaveChangesAsync();
                return model;
           
        }
        public async Task<CategoryDTO> DeletCategoryAsync(int id)
        {
            var deletCategoryAsync = _context.Categories!.SingleOrDefault(c => c.CategoryId == id);
            var obj = _mapper.Map<CategoryDTO>(deletCategoryAsync);
            if (deletCategoryAsync != null)
            {
                _context.Categories!.Remove(deletCategoryAsync);
                await _context.SaveChangesAsync();
            }
            return obj;
        }

        public async Task<List<CategoryDTO>> GetAllCategoriesAsync()
        {
            try
            {
                var getAllCategoriesAsync = await _context.Categories!.ToListAsync();

                return _mapper.Map<List<CategoryDTO>>(getAllCategoriesAsync);
            }
            catch (Exception)
            {
                throw;
            }     
        }

        public async Task<CategoryDTO> GetCategoryAsync(int id)
        {
           var getCategoryAsync= await  _context.Categories!.FindAsync(id);

            return _mapper.Map<CategoryDTO>(getCategoryAsync);
        }

       
    }
}
