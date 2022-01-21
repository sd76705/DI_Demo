using DI_Demo.Model.DAL.First;
using DI_Demo.Domain;

namespace DI_Demo.Model.BL.First;

public class ProductBL
{
    private readonly ProductDAL _productDAL;

    public ProductBL()
    {
        //建構式就 new 出實作的DAL服務
        _productDAL = new ProductDAL();
    }
        
    public IEnumerable<ProductModel> GetProducts(string? name)
    {
        return _productDAL.GetProducts(name);
    }
}
