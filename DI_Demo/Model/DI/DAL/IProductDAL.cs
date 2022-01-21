using DI_Demo.Domain;

namespace DI_Demo.Model.Second.DAL;

public interface IProductDAL
{
    IEnumerable<ProductModel> GetProducts(string? name);
}
