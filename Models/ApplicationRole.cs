using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketLine.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string desc, DateTime creationDate) : base(roleName)
        {
            this.Description = desc;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
