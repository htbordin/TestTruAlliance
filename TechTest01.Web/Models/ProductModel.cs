using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTest01.Services.Catalog;
using TechTest01.Domain.Catalog;

namespace TechTest01.Web.Models
{
    public partial class ProductModel
    {

        public IList<Product> ProductList { get; set; }
    }
}