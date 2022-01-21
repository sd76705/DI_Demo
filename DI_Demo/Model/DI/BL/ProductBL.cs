using DI_Demo.Domain;
using DI_Demo.Model.Second.BL;
using DI_Demo.Model.Second.DAL;

namespace DI_Demo.Model.DI.BL;

public class ProductBL : IProductBL
{
    private readonly IProductDAL _productDAL;

    public ProductBL(IProductDAL productDAL)
    {
        //建構式只需指定介面，而介面會由DI決定實作的Service
        _productDAL = productDAL;
    }

    public IEnumerable<ProductModel> GetProducts(string? name)
    {
        return _productDAL.GetProducts(name);
    }
}
