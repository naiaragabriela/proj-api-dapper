using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proj_api_dapper.Models;
using Repositories;

namespace proj_api_dapper.Services
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public int Insert(Product product)
        {
            return _productRepository.Insert(product);

        }

        public bool Update(Product product)
        {
            return _productRepository.Update(product);

        }

        public bool Delete(int id)
        {
            return _productRepository.Delete(id);
        }
        public List<Product> ToList()
        {
            return _productRepository.ToList();
        }

        public Product ConsultId(int id)
        {
            return _productRepository.ConsultId(id);
        }
    }
}
