using CrushonCase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CrushonCase.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var retailers = Db.GetInstance().Users;

            return View(retailers);
        }

        public IActionResult Add()
        {
            var model = new UserModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddPost(UserModel model)
        {
            Db.GetInstance().Users.Add(model);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
