using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Services;
using TechTest01.Services.Catalog;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : BaseController
    {


        // GET: Home
        public ActionResult Index()
        {

            ProductModel model = new ProductModel();

           
            model.ProductList = Service.GetAllProducts();
            return View(model);
        }
    }
}