using ProductManagementDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementBusiness.Services
{
    public interface IProductService
    {
        Task<object> Add(Product product);
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> GetByName(string name);
        Task<int> GetCount();
        Task<List<Product>> GetProductByCategory(string category);
        Task<List<Product>> SortProducts();
        Task<object> Update(Product product);
        Task<object> Delete(int id);
        Task<object> DeleteAll();
    }
}
