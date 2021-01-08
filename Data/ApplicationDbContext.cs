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
        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<Airport> Airport { get; set; }

        public DbSet<Flight> Flight { get; set; }

        public DbSet<Airplane> Airplane { get; set; }

        public DbSet<Seat> Seat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Flight>()
                        .HasOne(m => m.Boarding)
                        .WithMany(t => t.DepartureFlights)
                        .HasForeignKey(m => m.BoardingId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Flight>()
                        .HasOne(m => m.Destination)
                        .WithMany(t => t.ArrivalFlights)
                        .HasForeignKey(m => m.DestinationId)
                        .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
