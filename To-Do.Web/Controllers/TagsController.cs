using Microsoft.AspNetCore.Mvc;

namespace To_Do.Web.Controllers
{
    public class TagsController : Controller
    {
        public IActionResult Index()
        {
            // Controller MVC pentru gestionarea tag-urilor
            return View();
        }
    }
}
