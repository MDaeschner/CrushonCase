using CrushonCase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CrushonCase.Controllers
{
    public class BrandController : Controller
    {

        public IActionResult Index()
        {
            var brands = Db.GetInstance().Brands;

            return View(brands);
        }

        public IActionResult Add()
        {
            var model = new BrandModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddPost(BrandModel model)
        {
            Db.GetInstance().Brands.Add(model);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
