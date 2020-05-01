namespace AKQAWebApp.Controllers
{
    using AKQAWebApp.Models;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel
            {
                ServiceBaseUrl = "http://localhost:53871/"
            };
            return View(viewModel);
        }
    }
}