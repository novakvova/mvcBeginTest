using Baton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baton.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<ProductModel> model = new List<ProductModel>()
            {
                new ProductModel
                {
                    Id=1,
                    Name="Бородінський хліб",
                    Image="https://aerodecor.com.ua/images/%D0%91%D0%BE%D1%80%D0%BE%D0%B4%D0%B8%D0%BD%D1%81%D0%BA%D0%B8%D0%B9-%D1%85%D0%BB%D0%B5%D0%B11_tn.jpg"
                },
                new ProductModel
                {
                    Id=2,
                    Name="Бородінський хліб",
                    Image="https://aerodecor.com.ua/images/%D0%91%D0%BE%D1%80%D0%BE%D0%B4%D0%B8%D0%BD%D1%81%D0%BA%D0%B8%D0%B9-%D1%85%D0%BB%D0%B5%D0%B11_tn.jpg"
                }
            };
            return View(model);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}