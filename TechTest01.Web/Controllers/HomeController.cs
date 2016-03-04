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
    public class HomeController : BaseController
    {


        // GET: Home
        public ActionResult Index()
        {

            ProductModel model = new ProductModel();

            Random rnd = new Random();
           
            model.ProductList = Service.GetAllProducts().OrderBy(x => rnd.Next()).Take(2).ToList();
            return View(model);
        }

    }
}