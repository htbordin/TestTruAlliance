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
    public class ProductController : BaseController
    {


        // GET: Home
        public ActionResult Index(string slug)
        {

            ProductSingleModel model = new ProductSingleModel();


            model.Product = Service.GetProductSlug(slug);
            return View(model);
        }
    }
}