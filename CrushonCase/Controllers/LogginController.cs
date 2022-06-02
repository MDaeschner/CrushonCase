using CrushonCase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CrushonCase.Controllers
{
    public class LogginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPost(LogginModel model)
        {
            // Loggins dispos
            var users = Db.GetInstance().Users;

            // Vérif validité
            foreach (var user in users)
            {
                if (user.Email == model.Email)
                {
                    HttpContext.Session.SetString("EmailUser",user.Email);
                    HttpContext.Session.SetString("UserRole", user.Role);
                    HttpContext.Session.SetInt32("UserID", user.UserID);
                    // Accueil
                    return RedirectToAction("Index", "Home");
                }
            }
            // Retour au loggin
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
