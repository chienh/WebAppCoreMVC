using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAppCoreMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["msg"] = "Olá, " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}
