using ProductManagementBusiness.Response;
using ProductManagementDomain.Models;
using ProductManagementDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementBusiness.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<object> Add(Product product)
        {
            object result = await _repository.Add(product);
            if (result != null)
                return new ProductResponse { statusCode = 200, message = "Success", response = result };
            else
                return new ProductResponse { statusCode = 201, message = "Failed", response = null };
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
