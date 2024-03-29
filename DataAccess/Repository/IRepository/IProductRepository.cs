﻿using Models.DataModels;

namespace DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
        //Task<Product> GetProductDetails(int? productId);
        //Task<List<Product>> GetProductsWithDetails();
    }
}