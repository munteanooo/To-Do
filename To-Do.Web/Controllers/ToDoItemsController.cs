﻿using Microsoft.AspNetCore.Mvc;

namespace To_Do.Web.Controllers
{
    public class ToDoItemsController : Controller
    {
        public IActionResult Index()
        {
            // Controller MVC pentru paginile de ToDo (listă, creare, editare)
            return View();
        }
    }
}
