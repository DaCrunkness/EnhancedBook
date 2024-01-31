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

        public void Update (Product product)
        {
            var dbProduct = _db.Products.FirstOrDefault(u=>u.Id == product.Id);
            if (dbProduct != null)
            {
                dbProduct.Title = product.Title;
                dbProduct.Author = product.Author;
                dbProduct.Description = product.Description;    
                dbProduct.ISBN = product.ISBN;
                dbProduct.Price = product.Price;
                dbProduct.ListPrice = product.ListPrice;
                dbProduct.Price50 = product.Price50;
                dbProduct.Price100 = product.Price100;
                if (product.ImageUrl != null)
                {
                    dbProduct.ImageUrl = product.ImageUrl;
                }
            }
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
