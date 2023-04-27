using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proj_api_dapper.Models;

namespace Repositories
{
    internal interface IProductRepository
    {
        int Insert(Product product);
        bool Update(Product product);
        bool Delete(int id);
        List<Product> ToList();
        Product ConsultId();
    }
}
