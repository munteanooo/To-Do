using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do.Domain.Entities
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
    }
}
