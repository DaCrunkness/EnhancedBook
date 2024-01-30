using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private DataContext _db;

        public ProductRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        //public async Task<Product> GetProductDetails(int? productId)
        //{
        //    return await _db.Products.Where(i => i.Id == productId).Include(c => c.Classification).Include(c => c.Category).Include(pt => pt.ProductType).Include(i => i.Item).ThenInclude(m => m.Media).Include(p => p.Promo).Include(d => d.Delivery).FirstAsync();
        //}

        //public async Task<List<Product>> GetProductsWithDetails()
        //{
        //    return await _db.Products.Include(c => c.Classification).Include(c => c.Category).Include(pt => pt.ProductType).Include(i => i.Item).ThenInclude(m => m.Media).Include(p => p.Promo).Include(d => d.Delivery).ToListAsync();
        //}
    }
}
