using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do.Domain.Entities;

namespace To_Do.Domain.Contracts
{
    public interface IToDoRepository
    {
        Task<List<ToDoItem>> GetByUserIdAsync(Guid userId);
        Task AddAsync(ToDoItem item);
    }
}
