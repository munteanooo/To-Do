using Microsoft.AspNetCore.Mvc;

namespace To_Do.API.Controllers
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
