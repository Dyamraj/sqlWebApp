using WebAppWithSql_new.Models;

namespace WebAppWithSql_new.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}

