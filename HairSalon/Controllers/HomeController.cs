using Microsoft.AspNetCore.Mvc;

namespace NamespaceOfProject.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.PageTitle = "Claire's Cuttery";
        return View();
      }

    }
}