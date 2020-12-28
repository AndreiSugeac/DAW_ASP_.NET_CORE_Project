using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketLine.Models;

namespace TicketLine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TicketLine.Models.Ticket> Ticket { get; set; }

        public DbSet<TicketLine.Models.Airport> Airport { get; set; }

        public DbSet<TicketLine.Models.Flight> Flight { get; set; }
    }
}
