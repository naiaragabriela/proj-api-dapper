namespace proj_api_dapper.Models
{
    public class Stock
    {
        public int IdStock { get; set; }
        public string StockName { get; set;}
        public Product Product { get; set;} 
    }
}