using Microsoft.AspNetCore.Mvc;
using To_Do.Application.DTOs;
using To_Do.Application.Services;

namespace To_Do.API.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoService _service;
        public ToDoController(ToDoService service) => _service = service;

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAll(Guid userId) =>
            Ok(await _service.GetAllForUserAsync(userId));

        [HttpPost("{userId}")]
        public async Task<IActionResult> Add(Guid userId, [FromBody] ToDoCreateDto dto)
        {
            await _service.AddAsync(userId, dto);
            return Ok();
        }
    }
}
