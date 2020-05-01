namespace AKQAWebApp.Controllers
{
    using AKQAWebApp.Models;
    using System.Configuration;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string serviceBaseUrl = ConfigurationManager.AppSettings["ServiceBaseUrl"].ToString();
            HomeViewModel viewModel = new HomeViewModel
            {
                ServiceBaseUrl = !serviceBaseUrl.EndsWith("/") ? $"{serviceBaseUrl}/" : serviceBaseUrl
            };
            return View(viewModel);
        }
    }
}