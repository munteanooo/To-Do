using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do.Domain.Entities;    

namespace To_Do.Domain.Contracts
{
    public interface IUserRepository
    {
        Task<AppUser?> GetByUsernameAsync(string username);
        Task AddAsync(AppUser user);
    }
}
