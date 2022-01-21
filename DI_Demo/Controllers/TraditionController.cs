using DI_Demo.Model.BL.First;
using DI_Demo.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers;

/// <summary>
/// 第一次嘗試-傳統模式
/// </summary>
[ApiController]
[Route("[controller]")]
public class TraditionController : Controller
{
    private readonly ProductBL _productBL;

    public TraditionController()
    {
        //建構式就 new 出實作的BL服務
        _productBL = new ProductBL();
    }

    [HttpGet]
    public IEnumerable<ProductModel> Get(string? name)
    {
        var products = _productBL.GetProducts(name);

        return products;
    }
}
