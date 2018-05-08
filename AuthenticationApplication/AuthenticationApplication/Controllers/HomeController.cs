namespace AuthenticationApplication.Controllers
{
    using System.Diagnostics;
    using AuthenticationApplication.Framework;
    using AuthenticationApplication.Models;
    using Microsoft.AspNetCore.Mvc;

    [ExceptionFilter]
    public class HomeController : Controller
    {
        [ExceptionFilter]
        public IActionResult Index()
        {
            return View();
        }

        [ExceptionFilter]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ExceptionFilter]
        public IActionResult Welcome(string name, string lastName)
        {
            return View(new User { FirstName=name, LastName=lastName});
        }
    }
}
