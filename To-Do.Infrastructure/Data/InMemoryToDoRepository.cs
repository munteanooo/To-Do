using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do.Domain.Contracts;
using To_Do.Domain.Entities;

namespace To_Do.Infrastructure.Data
{
    public class InMemoryToDoRepository : IToDoRepository
    {
        private readonly List<ToDoItem> _items = new();

        public Task<List<ToDoItem>> GetByUserIdAsync(Guid userId) =>
            Task.FromResult(_items.Where(i => i.UserId == userId).ToList());

        public Task AddAsync(ToDoItem item)
        {
            _items.Add(item);
            return Task.CompletedTask;
        }
    }
}
