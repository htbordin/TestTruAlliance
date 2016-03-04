using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Services.Catalog
{
    

    public class ProductService  : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> repository)
        {
            _productRepository = repository;
        }
        public virtual Product GetProductById(object Id)
        {
            return _productRepository.GetById(Id);
        }

        public virtual IList<Product> GetAllProducts()
        {
            var query = from p in _productRepository.Context.Products
                        orderby  p.Name
                        select p;
            var products = query.ToList();
            return products;
        }
        public virtual Product GetProductSlug(string slug)
        {
            var query = from p in _productRepository.Context.Products
                        where p.Slug ==  slug
                        select p;
            var product = query.FirstOrDefault();
            return product;
        }

    }                   
}
