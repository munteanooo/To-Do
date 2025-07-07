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
    public class AuthService
    {
        private readonly IUserRepository _repo;
        public AuthService(IUserRepository repo) => _repo = repo;

        public async Task<AppUser?> LoginAsync(UserLoginDto dto)
        {
            var user = await _repo.GetByUsernameAsync(dto.Username);
            if (user == null) return null;

            var hash = Hash(dto.Password);
            return user.PasswordHash == hash ? user : null;
        }

        private string Hash(string password) =>
            Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
    }

}
