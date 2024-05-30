using ProductManagementDomain.Infrastructure;
using ProductManagementDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementDomain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<object> Add(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public async Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> DeleteAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetCount()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProductByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> SortProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<object> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
