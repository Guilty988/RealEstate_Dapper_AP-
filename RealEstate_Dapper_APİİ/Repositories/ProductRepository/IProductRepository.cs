using RealEstate_Dapper_APİİ.Dtos.ProductDtos;

namespace RealEstate_Dapper_APİİ.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
    }
}
