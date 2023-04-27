using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proj_api_dapper.Models;

namespace Repositories
{
    public interface IKindRepository
    {
        int Insert(Kind kind);
        bool Update(Kind kind);
        bool Delete(int id);
        List<Kind> ToList();
        Kind ConsultId(int id);
    }
}
