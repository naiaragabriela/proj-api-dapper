using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proj_api_dapper.Models;
using proj_api_dapper.Services;

namespace proj_api_dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindController : ControllerBase
    {

        private KindService _kindService;
        public KindController(KindService kindService)
        {
            _kindService = new KindService();
        }

        [HttpGet]
        public ActionResult<List<Kind>> Get() => _kindService.ToList();

        [HttpGet]
        public ActionResult<Kind> ConsultId(int id) => _kindService.ConsultId(id);

        [HttpPost]
        public int Insert(Kind kind) => _kindService.Insert(kind);

        [HttpPut]
        public bool Update (Kind kind) => _kindService.Update(kind);

        [HttpDelete]
        public bool Delete(int id) => _kindService.Delete(id);
    }
}
