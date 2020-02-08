using Baton.Entities;
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
        private static List<ProductModel> products = new List<ProductModel>()
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

        // GET: Home
        public ActionResult Index()
        {
            return View(products);
        }
        // GET: Home
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(ProductAddModel model)
        {
            MyContext context = new MyContext();

            //ProductModel item = new ProductModel
            //{
            //    Id = products.Count + 1,
            //    Name = model.Name,
            //    Image = model.Image
            //};
            //products.Add(item);
            Category c = new Category();
            c.Name = model.Name;
            context.Categories.Add(c);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        // GET: Home
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var product = products.SingleOrDefault(p => p.Id==id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var prod = products.SingleOrDefault(p => p.Id == id);
            products.Remove(prod);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}