using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services.Catalog;
using TechTest01.Repository;
using TechTest01.Domain.Catalog;


namespace TechTest01.Web.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected IProductService _service;
        public IProductService Service
        {
            get
            {
                if (_service == null)
                {
                    _service = new ProductService(
                        new Repository<Product>(
                            new ProductContext())
                        );
                }
                return _service;
            }
        }


    }
}