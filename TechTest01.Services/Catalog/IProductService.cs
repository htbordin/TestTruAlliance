using System.Collections.Generic;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Services.Catalog
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        Product GetProductById(object Id);
        Product GetProductSlug(string slug);
    }
}
