using Microsoft.AspNetCore.Mvc;

namespace To_Do.Web.Controllers.Api
{
    public class ToDoItemsApiController : Controller
    {
        public IActionResult Index()
        {
            // API pentru a prelua/modifica sarcini via AJAX (ex: pentru calendar
            return View();
        }
    }
}
