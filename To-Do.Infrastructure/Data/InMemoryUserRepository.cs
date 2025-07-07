using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do.Domain.Contracts;
using To_Do.Domain.Entities;

namespace To_Do.Infrastructure.Data
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<AppUser> _users = new();

        public Task<AppUser?> GetByUsernameAsync(string username) =>
            Task.FromResult(_users.FirstOrDefault(u => u.Username == username));

        public Task AddAsync(AppUser user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }
    }
}
