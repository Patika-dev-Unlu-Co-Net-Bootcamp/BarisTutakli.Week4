using BarisTutakli.Week4.WebApi.DataAccess.Common;
using BarisTutakli.Week4.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.WebApi.Business
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<int> Add(Product product)
        {
            return await _repository.Add(product);
        }

        public async Task<int> Delete(Product product)
        {
            return await _repository.Delete(product);
        }

        public Task<IList<Product>> Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _repository.GetAll();
        }

        public Task<Product> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<int> Update(Product product)
        {
            return await _repository.Update(product);
        }
    }
}
