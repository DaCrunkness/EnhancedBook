using Models.DataModels;

namespace DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        //Task<Product> GetProductDetails(int? productId);
        //Task<List<Product>> GetProductsWithDetails();
    }
}