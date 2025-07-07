using Microsoft.AspNetCore.Mvc;
using To_Do.Application.DTOs;
using To_Do.Application.Services;

public class AuthController : Controller
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(UserLoginDto dto)
    {
        var user = await _authService.LoginAsync(dto);
        if (user == null)
        {
            ModelState.AddModelError("", "Invalid credentials.");
            return View(dto);
        }

        // Poți salva în sesiune sau cookie
        HttpContext.Session.SetString("UserId", user.Id.ToString());
        return RedirectToAction("Index", "ToDo");
    }
}
