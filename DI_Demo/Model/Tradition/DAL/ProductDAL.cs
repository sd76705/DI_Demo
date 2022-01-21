using DI_Demo.Domain;

namespace DI_Demo.Model.DAL.First;
public class ProductDAL
{
    private readonly List<ProductModel> _products;

    public ProductDAL()
    {
        _products = new List<ProductModel>
        {
            new ProductModel { Id = 1, Name= "iPhone 12", Description = "iPhone 12 mobile phone" , Sales = 100},
            new ProductModel { Id = 2, Name= "iPhone 13", Description = "iPhone 13 mobile phone", Sales = 200},
            new ProductModel { Id = 3, Name= "iPhone 13 Pro", Description = "iPhone 13 Pro mobile phone", Sales = 300},
        };
    }

    public IEnumerable<ProductModel> GetProducts(string? name)
    {
        var result = _products.Where(p => string.IsNullOrEmpty(name) || p.Name.Contains(name))
                              .ToList();
        return result;
    } 

}