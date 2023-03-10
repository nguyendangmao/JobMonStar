using JobMonStar.Models;

namespace JobMonStar.Respository
{
    public interface ICategoryRepository
    {
        public Task<List<CategoryDTO>> GetAllCategoriesAsync();
        public Task<CategoryDTO> GetCategoryAsync(int id);
        public Task<CategoryDTO> AddCategoryAsync(CategoryDTO model);
        public Task<CategoryDTO> UpdateCategoryAsync(CategoryDTO model);
        public Task<CategoryDTO> DeletCategoryAsync(int id);
    }
}
