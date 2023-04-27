using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proj_api_dapper.Models;
using Repositories;

namespace proj_api_dapper.Services
{
    public class StockService
    {
        private IStockRepository _stockRepository;

        public StockService()
        {
            _stockRepository = new StockRepository();
        }

        public int Insert(Stock stock)
        {
            return _stockRepository.Insert(stock);

        }

        public bool Update(Stock stock)
        {
            return _stockRepository.Update(stock);

        }

        public bool Delete(int id)
        {
            return _stockRepository.Delete(id);
        }

        public List<Stock> ToList()
        {
            return _stockRepository.ToList();
        }

        public Stock ConsultId(int id)
        {
            return _stockRepository.ConsultId(id);
        }
    }
}
