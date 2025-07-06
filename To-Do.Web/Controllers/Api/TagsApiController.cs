using Microsoft.AspNetCore.Mvc;

namespace To_Do.API.Controllers.Api
{
    public class TagsApiController : Controller
    {
        public IActionResult Index()
        {
            // API pentru tag-uri (ex: autocomplete)
            return View();
        }
    }
}
