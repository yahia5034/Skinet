using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type,string? sort);

        Task<Product?> GetProductByIdAsync(int id);
        Task<IReadOnlyList<string>> GetBrandsAsync();

        Task<IReadOnlyList<string>> GetTypesAsync();
        void AddProduct(Product product);
        // This is not interacting with the db but the save changes is 

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);

        bool ProductExists(int id);

        Task<bool> SaveChangesAsync();


    }
}
