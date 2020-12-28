using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TicketLine.Models;

namespace TicketLine.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        public Airport Boarding { get; set; }

        public Airport Destination { get; set; }

        [Required]
        public DateTime TakeoffTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }
    }
}
