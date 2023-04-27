using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proj_api_dapper.Models;
using proj_api_dapper.Services;

namespace proj_api_dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private StockService _stockService;
        public StockController(StockService stockService)
        {
            _stockService = new StockService();
        }

        [HttpGet]
        public ActionResult<List<Stock>> Get() => _stockService.ToList();

        [HttpGet]
        public ActionResult<Stock> ConsultId(int id) => _stockService.ConsultId(id);

        [HttpPost]
        public int Insert(Stock stock) => _stockService.Insert(stock);

        [HttpPut]
        public bool Update(Stock stock) => _stockService.Update(stock);

        [HttpDelete]
        public bool Delete(int id) => _stockService.Delete(id);
    }
}
