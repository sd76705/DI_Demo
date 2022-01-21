using DI_Demo.Model.LifeTime;
using Microsoft.AspNetCore.Mvc;
using static DI_Demo.Model.LifeTime.LifeTimeSample;

namespace DI_Demo.Controllers;

/// <summary>
/// DI生命週期展示
/// </summary>
[ApiController]
[Route("[controller]")]
public class LifeTimeSampleController : Controller
{
    private readonly ISampleTransient _transient1;
    private readonly ISampleTransient _transient2;
    private readonly ISampleScoped _scoped1;
    private readonly ISampleScoped _scoped2;
    private readonly ISampleSingleton _singleton1;
    private readonly ISampleSingleton _singleton2;

    public LifeTimeSampleController(
        ISampleTransient transient1,
        ISampleTransient transient2,
        ISampleScoped scoped1,
        ISampleScoped scoped2,
        ISampleSingleton singleton1,
        ISampleSingleton singleton2)
    {
        this._transient1 = transient1;
        this._transient2 = transient2;
        this._scoped1 = scoped1;
        this._scoped2 = scoped2;
        this._singleton1 = singleton1;
        this._singleton2 = singleton2;
    }

    [HttpGet]
    public object Get()
    {
        var result = new 
        {
            transient = new 
            {
                Id_1 = _transient1.Id,
                Id_2 = _transient2.Id,
                HashCode_1 = _transient1.GetHashCode(),
                HashCode_2 = _transient2.GetHashCode(),
            },
            scoped = new
            {
                Id_1 = _scoped1.Id,
                Id_2 = _scoped2.Id,
                HashCode_1 = _scoped1.GetHashCode(),
                HashCode_2 = _scoped2.GetHashCode(),
            },
            singleton = new
            {
                Id_1 = _singleton1.Id,
                Id_2 = _singleton2.Id,
                HashCode_1 = _singleton1.GetHashCode(),
                HashCode_2 = _singleton2.GetHashCode(),
            }
        };
         
        return result;
    }
}
