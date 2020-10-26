using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IelloTicket.Models.DBModels
{
    public class User
    {
        int Id { get; set; }
        string Email { get; set; }

        string Password { get; set; }

        string Name { get; set; }
        string Surname { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}
