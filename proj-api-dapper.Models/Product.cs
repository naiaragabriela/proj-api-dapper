using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_api_dapper.Models
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Type Type { get; set; }
    }
}
