using proj_api_dapper.Models;
using Repositories;

namespace proj_api_dapper.Services
{
    public class KindService
    {
        private IKindRepository _kindRepository;

        public KindService()
        {
            _kindRepository = new KindRepository();
        }

        public int Insert(Kind kind)
        {
            return _kindRepository.Insert(kind);

        }

        public bool Update(Kind kind)
        {
            return _kindRepository.Update(kind);

        }

        public bool Delete(int id)
        {
            return _kindRepository.Delete(id);
        }

        public List<Kind> ToList()
        {
            return _kindRepository.ToList();
        }

        public Kind ConsultId(int id)
        {
           return _kindRepository.ConsultId(id);
        }
    }
}