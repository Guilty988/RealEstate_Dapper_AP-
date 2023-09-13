using RealEstate_Dapper_APİİ.Dtos.CategoryDtos;

namespace RealEstate_Dapper_APİİ.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategoryId(int id);



    }
}
