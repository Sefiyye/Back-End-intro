
using Microsoft.AspNetCore.Mvc;

namespace Back_End.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            ViewBag.Product = "Cola";
            ViewData["Count"] = id;
            TempData["Type"] = "Cold";
            return RedirectToAction("About");
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ(string name, string surname)
        {
            string fullname = $"{name} {surname}";
            return View(fullname);
        }
    }
}
