using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proj_api_dapper.Models;

namespace Repositories
{
    public interface IStockRepository
    {
        int Insert(Stock stock);
        bool Update(Stock stock);
        bool Delete(int id);
        List<Stock> ToList();
        Stock ConsultId();
    }
}
