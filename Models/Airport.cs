using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketLine.Models
{
    public class Airport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        public virtual ICollection<Flight> ArrivalFlights { get; set; }
        public virtual ICollection<Flight> DepartureFlights { get; set; }

        public Airport()
        {
        }
    }
}
