using CrushonCase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace CrushonCase.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = Db.GetInstance().Products.Where(x => x.RetailerID == HttpContext.Session.GetInt32("UserID"));

            return View(products);
        }

        public IActionResult Add()
        {
            var model = new ProductModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddPost(ProductModel model)
        {
            Db.GetInstance().Products.Add(model);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
