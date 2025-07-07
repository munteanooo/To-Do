using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do.Application.DTOs;
using To_Do.Domain.Contracts;
using To_Do.Domain.Entities;    

namespace To_Do.Application.Services
{
    public class ToDoService
    {
        private readonly IToDoRepository _repo;
        public ToDoService(IToDoRepository repo) => _repo = repo;

        public Task<List<ToDoItem>> GetAllForUserAsync(Guid userId) =>
            _repo.GetByUserIdAsync(userId);

        public Task AddAsync(Guid userId, ToDoCreateDto dto) =>
            _repo.AddAsync(new ToDoItem
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                Title = dto.Title,
                IsCompleted = false
            });
    }
}
