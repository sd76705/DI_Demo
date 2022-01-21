using DI_Demo.Domain;
using DI_Demo.Model.Second.BL;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers;

/// <summary>
/// 第二次嘗試-使用 Interface + DI
/// </summary>
[ApiController]
[Route("[controller]")]
public class DIController : Controller
{
    private readonly IProductBL _productBL;

    public DIController(IProductBL productBL)
    {
        //建構式只需指定介面，而介面由DI決定實作的Service
        this._productBL = productBL;
    }

    [HttpGet]
    public IEnumerable<ProductModel> Get(string? name)
    {
        var products = _productBL.GetProducts(name);

        return products;
    }
}
