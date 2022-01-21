using DI_Demo.Domain;

namespace DI_Demo.Model.Second.BL;

public interface IProductBL
{
    IEnumerable<ProductModel> GetProducts(string? name);
}
